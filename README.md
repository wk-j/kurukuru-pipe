## Reproduce Kurukuru Bug

```
msbuild src/KurukuruPipe/KurukuruPipe.csproj

## ok
mono src/KurukuruPipe/bin/Debug/net47/KurukuruPipe.exe

## bug
echo hello | mono src/KurukuruPipe/bin/Debug/net47/KurukuruPipe.exe
```