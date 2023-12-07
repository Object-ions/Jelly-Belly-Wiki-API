By: Moses Atia Poston

## Jelly Belly Wiki

# Project's Purpose or Goal:
The Jelly Belly Wiki Web Application serves as a comprehensive and interactive platform for users to explore the diverse world of Jelly Belly candies. It aims to provide an immersive experience where users can delve into flavor profiles, discover innovative recipes, and learn about unique flavor combinations. This aligns with the playful and diverse nature of Jelly Belly beans, offering an engaging and informative resource.

# Minimum Features Required:
- Front-End Development: Utilize HTML, CSS, and JavaScript, employing React for a dynamic and responsive user interface.
- Back-End Development: Leverage C# alongside ASP .NET for robust API development and server-side processing.
- Database Management: Implement MySQL for efficient data storage and retrieval, ensuring data integrity and accessibility.
- API Functionalities: Integrate basic pagination and fetch requests to facilitate efficient data querying and retrieval from the server.

# Tools and Resources for MVP:
- Data Scraping: Python scripts with BeautifulSoup and Chromedriver to extract data from the official Jelly Belly website. This will capture over 110 bean varieties along with attributes like: Group Name, Flavor Name, Description, Ingredients, Group Color, Color, Image, and dietary specifications.
- Front-End Framework: React for building a user-friendly and interactive web interface.
- Back-End Framework: C# with ASP.NET for constructing a scalable and secure API. The API will support functionalities like bean-specific searches and general query searches.

# Post-MVP Development:
- Enhanced User Experience: Integration of CSS animations, JavaScript animations, and advanced graphical representations using Three.js and GSAP WebGL.
- Testing and Security: Implementation of unit testing for robust code functionality and API authentication for secure data access.
- Open Source API and Deployment: Preparation for open-source distribution, enabling external usage of the API. Consider deployment platforms like Azure or Render.com for hosting.

# Additional Tools for Enhanced Features:
Mentioned in the Post-MVP Development section, these include advanced animation libraries (Three.js, GSAP), testing frameworks (like Jest for React), and deployment services (Azure, Render.com).

This project encompasses three major phases: data scraping and management, API development, and UI creation. The decision to build a separate API and UI aims to ensure scalability and independence of each component. The API, designed with expansion in mind, can be easily scaled and integrated into various applications. Similarly, the React-based UI allows for flexible design changes while maintaining a consistent user experience.

