using System;
using System.Collections.Generic;
using System.Linq;

// ============================
// NewsArticle Class
// ============================
public class NewsArticle
{
    public string Title { get; set; }
    public string Category { get; set; }

    public NewsArticle(string title, string category)
    {
        Title = title;
        Category = category;
    }
}

// ============================
// NewsArticleCollection Class
// ============================
public class NewsArticleCollection
{
    private List<NewsArticle> articles = new List<NewsArticle>();

    // Delegates
    public Action<object, NewsArticle> articleAddedHandler;
    public Action<object, NewsArticle> articleRemovedHandler;
    public Action<object, string> articleFilteredHandler;

    // Add Article
    public void AddArticle(NewsArticle article)
    {
        articles.Add(article);
        articleAddedHandler?.Invoke(this, article);
    }

    // Remove Article
    public void RemoveArticle(NewsArticle article)
    {
        if (articles.Remove(article))
        {
            articleRemovedHandler?.Invoke(this, article);
        }
    }

    // Filter Articles
    public List<NewsArticle> FilterArticlesByCategory(string category)
    {
        var filtered = articles.Where(a => a.Category == category).ToList();
        articleFilteredHandler?.Invoke(this, category);
        return filtered;
    }

    // Register Handlers
    public void RegisterArticleAddedHandler(Action<object, NewsArticle> handler)
    {
        articleAddedHandler += handler;
    }

    public void RegisterArticleRemovedHandler(Action<object, NewsArticle> handler)
    {
        articleRemovedHandler += handler;
    }

    public void RegisterArticleFilteredHandler(string category, Action<object, string> handler)
    {
        // Wrap with category filter check
        articleFilteredHandler += (sender, cat) =>
        {
            if (cat == category)
            {
                handler(sender, cat);
            }
        };
    }
}

// ============================
// Console Application
// ============================
class Program
{
    static void Main()
    {
        var collection = new NewsArticleCollection();

        // Register Added Event
        collection.RegisterArticleAddedHandler((sender, article) =>
        {
            Console.WriteLine($"Article added: {article.Title} ({article.Category})");
        });

        // Register Removed Event
        collection.RegisterArticleRemovedHandler((sender, article) =>
        {
            Console.WriteLine($"Article removed: {article.Title} ({article.Category})");
        });

        // Register Filtered Event (Lambda Expression as required)
        collection.RegisterArticleFilteredHandler("Sports", (sender, category) =>
        {
            Console.WriteLine($"Articles filtered by category '{category}'");
        });

        // Add Articles
        var a1 = new NewsArticle("World Cup Final Highlights", "Sports");
        var a2 = new NewsArticle("New iPhone Release", "Technology");
        var a3 = new NewsArticle("Olympics 2026 Updates", "Sports");

        collection.AddArticle(a1);
        collection.AddArticle(a2);
        collection.AddArticle(a3);

        // Filter Sports
        collection.FilterArticlesByCategory("Sports");

        // Remove one Sports article
        collection.RemoveArticle(a1);

        // Filter Sports again
        collection.FilterArticlesByCategory("Sports");

        Console.ReadLine();
    }
}