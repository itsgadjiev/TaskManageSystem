﻿using LoginRegConsole.Database.BaseModel;
using Newtonsoft.Json;
using System.Reflection;

namespace LoginRegConsole.Database.BaseModels
{
	public class BaseRepository<TDomain>
		where TDomain : BaseEntity
	{
		private readonly List<TDomain> _entries;
		private readonly string _filePath;

		public BaseRepository(string filePath)
		{
			_filePath = filePath;
			if (!File.Exists(_filePath))
			{
				File.Create(_filePath).Close();
			}

			string json = File.ReadAllText(_filePath);
			_entries = JsonConvert.DeserializeObject<List<TDomain>>(json) ?? new List<TDomain>();
		}

		public void Add(TDomain entry)
		{
			_entries.Add(entry);
			SaveChanges();
		}
		public void Remove(TDomain entry)
		{
			_entries.Remove(entry);
			SaveChanges();
		}
		public void SaveChanges()
		{
			string json = JsonConvert.SerializeObject(_entries, Formatting.Indented);
			File.WriteAllText(_filePath, json);
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
		public void Update(TDomain entity, Action<TDomain> updateAction)
		{
			int index = _entries.IndexOf(entity);
			updateAction(entity);
			_entries[index] = entity;
			SaveChanges();
		}

	}
}
