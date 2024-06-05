Feature: Add
Scenario Outline: Add numbers
    When Add <firstNum> and <secondNum>
    Then the result should <result>
    Examples:
        | firstNum| secondNum | result |
        | 5       | 6         | 11     |
        | 2       | 2         | 4      |
        | 100     | 55        | 155    |