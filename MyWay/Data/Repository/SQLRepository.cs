using MyWay.Models;
using MyWay.Pages;
using System.Collections.Generic;
using System.Linq;

namespace MyWay.Data.Repository
{
	public class SQLRepository : IRepository
	{
		private readonly DB _context;

		public SQLRepository(DB context)
        {
			_context = context;
		}

		public void AddCategory(Category category)
		{
			_context.Categories.Add(category);
			_context.SaveChanges();
		}

		public void AddTag(Tag tag)
		{
			_context.Tags.Add(tag);
			_context.SaveChanges();
		}

		public void AddTour(Tour tour)
		{
			_context.Tours.Add(tour);
			_context.SaveChanges();
		}

		public void AddUser(User user)
		{
			_context.Users.Add(user);
			_context.SaveChanges();
		}

		public void DeleteCategory(int id)
		{
			var category = _context.Categories.Find(id);
			if (category != null)
			{
				_context.Categories.Remove(category);
				_context.SaveChanges();
			}
		}

		public void DeleteTag(int id)
		{
			var tag = _context.Tags.Find(id);
			if (tag != null)
			{
				_context.Tags.Remove(tag);
				_context.SaveChanges();
			}
		}

		public void DeleteTour(int tourId)
		{
			var  tour= _context.Tours.Find(tourId);
			if (tour != null)
			{
				_context.Tours.Remove(tour);
				_context.SaveChanges();
			}
		}

		public void DeleteUser(int id)
		{
			var user = _context.Users.Find(id);
			if (user != null)
			{
				_context.Users.Remove(user);
				_context.SaveChanges();
			}
		}

		public IEnumerable<Category> GetAllCategories()
		{
			return _context.Categories;
		}

		public IEnumerable<Tag> GetAllTags()
		{
			return _context.Tags;
		}

		public IEnumerable<Tour> GetAllTours()
		{
			return _context.Tours;
		}

		public IEnumerable<User> GetAllUsers()
		{
			return _context.Users;
		}

		public Category GetCategoryById(int id)
		{
			return _context.Categories.FirstOrDefault(c => c.Id == id);
		}

		public Category GetCategoryByName(string name)
		{
			return _context.Categories.FirstOrDefault(c => c.Name == name);
		}

		public Tag GetTagById(int id)
		{
			return _context.Tags.FirstOrDefault(t => t.Id == id);
		}

		public Tag GetTagByName(string name)
		{
			return _context.Tags.FirstOrDefault(t => t.Name == name);
		}

		public Tour GetTourById(int id)
		{
			return _context.Tours.FirstOrDefault(t => t.Id == id);
		}

		public IEnumerable<Tour> GetToursByCategory(string category)
		{
			return _context.Tours.Where(t => t.Counrty == category);
		}

		public IEnumerable<Tour> GetToursByCity(string city)
		{
			return _context.Tours.Where(t => t.City == city);
		}

		public IEnumerable<Tour> GetToursByCountry(string country)
		{
			return _context.Tours.Where(t => t.Counrty == country);
		}

		public IEnumerable<Tour> GetToursByTag(Tag tag)
		{
			return _context.Tours.Where(t => t.Tags.Contains(tag));
		}

		public IEnumerable<Tour> GetToursByTag(string tag)
		{
			throw new System.NotImplementedException();
		}

		public User GetUserById(int id)
		{
			return _context.Users.FirstOrDefault(t => t.Id == id);
		}

		public void UpdateTour(Tour tour)
		{
			var item = _context.Tours.Attach(tour);
			item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			_context.SaveChanges();
		}

		public void UpdateUser(User user)
		{
			var item = _context.Users.Attach(user);
			item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			_context.SaveChanges();
		}
	}
}
