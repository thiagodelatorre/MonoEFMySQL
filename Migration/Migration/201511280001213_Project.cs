using System.Data.Entity.Migrations.Infrastructure;

namespace EF
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Project : DbMigration, IMigrationMetadata
    {
        	string IMigrationMetadata.Id {
			get { return "201511280001213_Project"; }
		}

		string IMigrationMetadata.Source {
			get { return null; }
		}


		string IMigrationMetadata.Target {
			get { return "H4sIAAAAAAAAA81X3W7TMBS+5yksX4+42wSCKRka3Yom1q0ig3s3Oe0sHDvEztQ+Gxc8Eq/Acf6bdG0ZCKHeJM453/n8+fy4P7//8N+tEkkeITNCq4AeeyNKQEU6FmoZ0NwuXr6h785f+FdxsiJfarNTZ4aOygT0wdr0jDETPUDCjZeIKNNGL6wX6YTxWLOT0egtOz5mgBD0/AUh/qdcWZGAe8a3sVYRpDbncqpjkKZcxg9hAUlueQIm5REE9GpCyYUUHMOGIBeUcKW05RZJnX02ENpMq2WY4gKX9+sU0G7BpYGK7Flrfijv0YnjzVrHGirKjdXJbwIen1ZCsL77s+SktVQo1hVKatdu04VgAZ3hYTncfqSzscycmVPTK42OyNXkqDndkVf8jsg4lzbPIFCQ24zLIzLL51JEH2F9r7+CClQuZYcCksBP3XdcmWU6hcyuP8Gi4nUdU8I2vFjPrXHqeJSMr5U9PaHkFgPzuYTmdDu7C63O4AMoyLiFeMathUw5DCgE6sfuhZqIzFj3WEfElMJKoGTKVzeglvYhoPhIyUSsIK5XKhaflcDCQSeb5bAn0A3/N3H4EvaJ1/H3WZtGg9zCOrVcoLAV9LRYgZXdkmNYjFWamYrmBskSMAS7kauGkjZ8WeFencVbSDZ8mobByo5R9RW2vbH4U56mqHXbZ6oFEpZNZvwy/P1qTEoMFplhUTZEm0CYo3gwva8YGWkWGXjJLZ9zdzjjOBmYtcJvF7UOs6ltrzBbpWtz91y6NI2h59RqNUH+CVZUsRVoIjddp+9XdHMuebaltMda5ol6ojnscu4Uaxejs3wwVFuOXaR29WCgot66GMXCwN1nPSF7p8MGx7PZMftnvaM6ehZN5LpKNsvBr3Jz7yge5GppQgkK8ijiMk/Db9Jz373icSwF7rS1mHIlFmBsOU3oK+91b7r/P5OWGRPLQ8btPx2Hwqm5d+DtavgHTECJV6qyy7dAzxhwz4TpzK9it39teg177QETaseAKtM/oPFcI+GS4gx0Krdz3Du8BnXos8612b8EI5aNu7tDK4hcejd4tcW1WuhaVNxPh0pt0ZN8CpbHKMpFZsWCRxY/R2BMcT35wmXuBkQyh/ha3eU2ze2FMZDMZfdq5bOd0YvRvMHXv0vdi/lz9shQIHu4U+9zIeOG8mSYLk8guMyo6gkp4cUM0ZbrBuhWq8NwKt0uIQXlivEeklQilrlTIX+EZzDDW9UNLHm0rjvokxh7D2BDb/9S8GXGE1MCtM74x4+5f37nvwAa/ZrHKg4AAA=="; }
		}

	public override void Up()
        {
        }
        
        public override void Down()
        {
        }
    }
}
