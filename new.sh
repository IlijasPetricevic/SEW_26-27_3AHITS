#!/usr/bin/env bash
set -euo pipefail

action="create"
if [[ $# -eq 2 && "$1" == "--delete" ]]; then
  action="delete"
  project_name="$2"
elif [[ $# -eq 1 ]]; then
  project_name="$1"
else
  echo "Verwendung: ./new.sh [--delete] ProjektName"
  exit 1
fi

if [[ ! "$project_name" =~ ^[A-Za-z][A-Za-z0-9_]*$ ]]; then
  echo "Der Projektname muss mit einem Buchstaben beginnen und darf nur Buchstaben, Zahlen oder Unterstriche enthalten."
  exit 1
fi

solution_file="ConsoleApp.slnx"
project_dir="src/$project_name"
project_file="$project_dir/$project_name.csproj"

if [[ ! -f "$solution_file" ]]; then
  echo "Lösungsdatei $solution_file wurde nicht gefunden. Starte das Skript im Repository-Hauptordner."
  exit 1
fi

if [[ "$action" == "delete" ]]; then
  if [[ ! -d "$project_dir" || ! -f "$project_file" ]]; then
    echo "Das Projekt $project_name wurde nicht gefunden."
    exit 1
  fi

  dotnet sln "$solution_file" remove "$project_file"
  rm -rf -- "$project_dir"

  echo "Projekt $project_name wurde aus der Lösung entfernt und gelöscht."
  exit 0
fi

if [[ -e "$project_dir" ]]; then
  echo "Der Ordner $project_dir existiert bereits."
  exit 1
fi

dotnet new console --output "$project_dir" --name "$project_name" --use-program-main
program_file="$project_dir/Program.cs"
{
  printf '// ------------------------------\n// %s\n// ------------------------------\n\n' "$project_name"
  sed '1s/^\xEF\xBB\xBF//' "$program_file"
} > "$program_file.tmp"
mv "$program_file.tmp" "$program_file"
dotnet sln "$solution_file" add "$project_file"

echo
echo "Projekt $project_name wurde erstellt und zur Lösung hinzugefügt."
echo "Starten: dotnet run --project $project_dir"