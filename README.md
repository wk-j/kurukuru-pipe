## Reproduce Kurukuru Bug

### Build

```bash
msbuild src/KurukuruPipe/KurukuruPipe.csproj
```

### Bug

```bash
echo hello | mono src/KurukuruPipe/bin/Debug/net47/KurukuruPipe.exe
```

### Unexpeced output

```
⠋ Stage 2... ⠙ Stage 2... ⠹ Stage 2... ✖ Something went wrong!
```