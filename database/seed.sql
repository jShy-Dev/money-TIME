-- seed.sql: Insert sample data for initial testing

INSERT INTO users
    (email, full_name, auth_provider, total_income, pay_frequency)
VALUES
    ('test@example.com', 'Test User', 'Google', 60000, 'Monthly');

INSERT INTO bank_accounts
    (user_id, institution_name, account_type, account_number)
VALUES
    (1, 'Test Bank', 'Checking', '1234567890');

INSERT INTO budget_categories
    (user_id, category_name, monthly_limit, yearly_limit)
VALUES
    (1, 'Groceries', 500, 6000),
    (1, 'Utilities', 200, 2400),
    (1, 'Entertainment', 150, 1800);