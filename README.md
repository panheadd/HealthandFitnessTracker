HEALTH & FITNESS TRACKER API - ENDPOINTS

BASE URL:
http://localhost:5000

========================
USER ENDPOINTS
========================
POST   /api/users
GET    /api/users
GET    /api/users/{id}
PUT    /api/users/{id}
DELETE /api/users/{id}

========================
TRAINER ENDPOINTS
========================
POST   /api/trainers
GET    /api/trainers

========================
WORKOUT PLAN ENDPOINTS
========================
POST   /api/workout-plans
GET    /api/workout-plans
GET    /api/workout-plans/user/{userId}

========================
SESSION ENDPOINTS
========================
POST   /api/sessions
GET    /api/sessions
PUT    /api/sessions/complete/{id}

========================
EXERCISE LOG ENDPOINTS
========================
POST   /api/exercise-logs
GET    /api/exercise-logs

========================
GOAL ENDPOINTS
========================
POST   /api/goals
