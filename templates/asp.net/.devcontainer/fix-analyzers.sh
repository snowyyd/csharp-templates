#!/bin/bash
set -e

# https://github.com/dotnet/vscode-csharp/issues/7926#issuecomment-3376663931
for dir in "$HOME"/.vscode-server/extensions/ms-dotnettools.csharp-*-linux-x64; do
  target="$dir/.razoromnisharp/OmniSharpPlugin"
  if [ -d "$target" ]; then
    mv "$target" "$target.bak"
  fi
done

echo "Done! Please reload VSCode"
