using System.Collections.Generic;

namespace Minsk.CodeAnalysis
{
    sealed class BinaryExpressionSyntax : ExpressionSyntax
    {
        public BinaryExpressionSyntax(ExpressionSyntax left, ExpressionSyntax right, SyntaxToken operatorToken)
        {
            Left = left;
            Right = right;
            OperatorToken = operatorToken;
        }

        public override SyntaxKind Kind => SyntaxKind.BinaryExpressionToken;
        public ExpressionSyntax Left { get; }
        public ExpressionSyntax Right { get; }
        public SyntaxToken OperatorToken { get; }

        public override IEnumerable<SyntaxNode> GetChildren()
        {
            yield return Left;
            yield return OperatorToken;
            yield return Right;
        }
    }


}