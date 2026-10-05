using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200237D RID: 9085
	[Token(Token = "0x200237D")]
	public interface IPathFinding
	{
		// Token: 0x0600E666 RID: 58982
		[Token(Token = "0x600E666")]
		void GenerateNextMap(PathRequest request, Route.Node[,] nextMap);

		// Token: 0x0600E667 RID: 58983
		[Token(Token = "0x600E667")]
		void ClearCache(MotionMode motionMode);

		// Token: 0x0600E668 RID: 58984
		[Token(Token = "0x600E668")]
		void ClearAllCaches();

		// Token: 0x0600E669 RID: 58985
		[Token(Token = "0x600E669")]
		bool CheckReachable(PathRequest request, GridPosition targetPos, bool avoidObstacleLike);

		// Token: 0x0600E66A RID: 58986
		[Token(Token = "0x600E66A")]
		bool TryCalculatePathFindingDistance(PathRequest request, GridPosition startPos, out int distance);
	}
}
