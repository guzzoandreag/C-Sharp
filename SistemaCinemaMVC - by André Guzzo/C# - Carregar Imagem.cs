try
{
    if (!string.IsNullOrEmpty(imgCaminho))
    {
        FileInfo arqImagem = new FileInfo(imgCaminho);
        FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
        this.Foto = new byte[Convert.ToInt32(arqImagem.Length)];
        int iBytesRead = fs.Read(this.Foto, 0, Convert.ToInt32(arqImagem.Length));
        fs.Close();
    }
}
catch (Exception erro)
{
    throw new Exception(erro.Message.ToString());
}