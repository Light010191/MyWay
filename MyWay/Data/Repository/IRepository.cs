using MyWay.Models;
using System.Collections.Generic;

namespace MyWay.Data.Repository
{
	public interface IRepository
	{
		IEnumerable<Tour> GetAllTours();
		IEnumerable<Tour> GetToursByTag(string tag);
		IEnumerable<Tour> GetToursByCategory(string category);
		IEnumerable<Tour> GetToursByCity(string city);
		IEnumerable<Tour> GetToursByCountry(string country);
		Tour GetTourById(int id);
		void AddTour(Tour tour);
		void UpdateTour(Tour tour);
		void DeleteTour(int tourId);
		IEnumerable<User> GetAllUsers();
		User GetUserById(int id);
		void AddUser(User user);
		void UpdateUser(User user);
		void DeleteUser(int id);
		IEnumerable<Category> GetAllCategories();
		Category GetCategoryByName(string name);
		Category GetCategoryById(int id);
		void AddCategory(Category category);
		void DeleteCategory(int id);
		IEnumerable<Tag> GetAllTags();
		Tag GetTagById(int id);
		Tag GetTagByName(string name);
		void AddTag(Tag tag);
		void DeleteTag(int id);


	}
}
