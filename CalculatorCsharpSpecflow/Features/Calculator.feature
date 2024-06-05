Feature: Calculator Operations
Scenario Outline: Add numbers
    When I add <firstNum> and <secondNum>
    Then the result should be <result>
    Examples:
        | firstNum | secondNum | result |
        | 5        | 6         | 11     |
        | 2        | 2         | 4      |
        | 100      | 55        | 155    |
        | -10      | -5        | -15    |

Scenario Outline: Subtract numbers
    When I subtract <secondNum> from <firstNum>
    Then the result should be <result>
    Examples:
        | firstNum | secondNum | result |
        | 10       | 5         | 5      |
        | 20       | 5         | 15     |
        | 100      | 55        | 45     |
		| -10      | -5        | -5     |

Scenario Outline: Multiply numbers
    When I multiply <firstNum> and <secondNum>
    Then the result should be <result>
    Examples:
        | firstNum | secondNum | result |
        | 5        | 6         | 30     |
        | 2        | 2         | 4      |
        | 10       | 10        | 100    |
		| -5       | 5         | -25    |

Scenario Outline: Divide numbers
    When I divide <firstNum> by <secondNum>
    Then the result should be <result>
    Examples:
        | firstNum | secondNum | result |
        | 10       | 5         | 2      |
        | 20       | 5         | 4      |
        | 100      | 10        | 10     |
		| -10      | 5         | -2     |