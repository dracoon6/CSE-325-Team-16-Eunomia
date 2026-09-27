# CSE-325-Team-16-Eunomia

Eunomia is a Blazor-based personal media activity tracker. Users can keep one library for movies, TV shows, books, music, and games, and track what they have completed, are currently enjoying, or want to try.

## Project purpose

The app helps users remember and organize their media activities. Users can:

- see a dashboard summary of their activity by status
- search, filter, and sort their personal library
- track a title's category, status, rating, notes, and dates
- view, edit, and delete media items
- create a demo account with a separate in-memory collection

Account and media data are currently held in memory for the demo. The final database, authentication, and persistence design remain for the rest of the team.

## Core features

- Dashboard counts for completed, currently enjoying, and want-to-try items
- Personal media library across five categories, including books
- Search, category/status filters, and sorting
- Add, edit, and delete workflows with ratings, notes, and dates
- Demo account creation and per-account collections

## Current scope

- Blazor activity dashboard and personal media library
- sample collection covering all five media categories
- in-memory account and item state for demonstrating the workflows

Not included in this build:

- final database schema
- login/authentication backend
- production persistence layer
- cloud deployment setup

## Getting started

1. Open the project in Visual Studio or VS Code.
2. Restore NuGet packages.
3. Run the app with `dotnet run`.
4. Open the local URL shown in the terminal.

## Project structure

- `Components/` — Blazor pages and shared layout
- `Models/` — media activity and user account models
- `wwwroot/` — static assets
