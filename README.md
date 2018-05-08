# MiniPriceCalculator
An order form and store for my miniature painting services.  This was originally to be a calculator.  However, due to the issue of constantly referencing tables to generate a price, I've decided to treat this project more like a store and give each service I offer a static price until I see fit.

Instead of the local database connection that seems to be recommended, I have an mdf file within the MiniPriceCalculator.WebUI project in a folder called App_Data.  I have not been able to commit this to the repository, which is probably for the best since it currently contains pricing information that I haven't finalized yet and may contain customer information in the future.  The connection string can be easily updated in Web.config in the WebUI project.
