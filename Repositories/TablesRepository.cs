using rezervari.Models;

namespace rezervari.Repositories
{
  class TablesRepository
  {
    private List<Table> tables = new List<Table>();

    public void Add(Table table)
    {
      table.Id = tables.Count > 0 ? tables.Max(t => t.Id) + 1 : 1;
      tables.Add(table);
    }

    public List<Table> GetAll()
    {
      return tables;
    }

    public Table? GetById(int id)
    {
      return tables.FirstOrDefault(t => t.Id == id);
    }

    public bool Delete(int id)
    {
      Table? table = GetById(id);
      if (table != null)
      {
        tables.Remove(table);
        return true;
      }
      return false;
    }
  }
}
