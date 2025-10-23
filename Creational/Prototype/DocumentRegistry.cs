namespace Prototype;

public class DocumentRegistry
{
    private Dictionary<string, IDocument> _documents = new();

    public void RegisterDocument(string key, IDocument doc)
    {
        _documents[key] = doc;
    }

    public IDocument CreateClone(string key)
    {
        if (!_documents.ContainsKey(key))
        {
            throw new ArgumentException($"Document type '{key}' not found in registry");
        }

        return _documents[key].Clone();
    }
}