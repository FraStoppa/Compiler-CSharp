using System.Collections.Generic;

namespace Minsk.CodeAnalysis
{
    sealed class ParenthesizedExpressionSyntax : ExpressionSyntax
    {
        public ParenthesizedExpressionSyntax(SyntaxToken openParenthsisToken, ExpressionSyntax expression, SyntaxToken closeParanthesisToken)
        {
            OpenParenthesisToken = openParenthsisToken;
            Expression = expression;
            CloseParanthesisToken = closeParanthesisToken;
        }

        public SyntaxToken OpenParenthesisToken { get; }
        public ExpressionSyntax Expression { get; }
        public SyntaxToken CloseParanthesisToken { get; }

        public override SyntaxKind Kind => SyntaxKind.ParenthesizedExpression;

        public override IEnumerable<SyntaxNode> GetChildren()
        {
            yield return OpenParenthesisToken;
            yield return Expression;
            yield return CloseParanthesisToken;
        }
    }


}