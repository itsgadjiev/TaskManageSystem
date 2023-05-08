using LoginRegConsole.Database.BaseModel;

namespace LoginRegConsole.Database.BaseModels
{
	public class BaseRepository<TDomain>
		where TDomain : BaseEntity
	{
		public int Id { get; set; }

		private readonly List<TDomain> _entries;
		public BaseRepository(List<TDomain> entries)
		{
			_entries = entries;
		}


		public List<TDomain> GetAll()
		{
			return _entries;
		}

		public List<TDomain> GetAllBy(Predicate<TDomain> predicate)
		{
			List<TDomain> entries = new List<TDomain>();
			foreach (TDomain entry in _entries)
			{
				if (predicate(entry))
				{
					entries.Add(entry);
				}
			}
			return entries;
		}

		public List<TDomain> GetAllBy(Predicate<TDomain> predicate1, Predicate<TDomain> predicate2)
		{
			List<TDomain> entries = new List<TDomain>();
			foreach (TDomain entry in _entries)
			{
				if (predicate1(entry) && predicate2(entry))
				{
					entries.Add(entry);
				}
			}
			return entries;
		}

		public void Add(TDomain entry)
		{
			_entries.Add(entry);
		}

		public void Remove(TDomain entry)
		{
			_entries.Remove(entry);
		}

		public TDomain? GetBy(Predicate<TDomain> predicate)
		{

			foreach (var entry in _entries)
			{
				if (predicate(entry))
				{
					return entry;
				}
			}
			return default;
		}
	}
}
