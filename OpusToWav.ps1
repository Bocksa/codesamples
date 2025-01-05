# essentially equivalent of a foreach loop, iterate over all *.opus files in the current directory
Get-ChildItem -File -Filter "*.opus" | ForEach-Object {
    # convert all OPUS files to *.wav with PCM_S161E codec at 44.1KHz with 2 channels
    ffmpeg -i $_.FullName -vn -acodec pcm_s16le -ar 44100 -ac 2 "$($_.BaseName).wav"
    
    # delete the original opus, leaving just the wav
    Remove-Item $_.FullName
}
