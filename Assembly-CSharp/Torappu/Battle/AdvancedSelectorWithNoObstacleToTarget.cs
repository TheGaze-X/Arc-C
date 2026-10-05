using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024F2 RID: 9458
	[Token(Token = "0x20024F2")]
	public class AdvancedSelectorWithNoObstacleToTarget : AdvancedSelector
	{
		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x0600F3A4 RID: 62372 RVA: 0x00059DC0 File Offset: 0x00057FC0
		[Token(Token = "0x17001FBC")]
		public bool checkEntityBlacklist
		{
			[Token(Token = "0x600F3A4")]
			[Address(RVA = "0x69F750", Offset = "0x69E350", VA = "0x18069F750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F3A5 RID: 62373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3A5")]
		[Address(RVA = "0x69E900", Offset = "0x69D500", VA = "0x18069E900", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F3A6 RID: 62374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3A6")]
		[Address(RVA = "0x69E6F0", Offset = "0x69D2F0", VA = "0x18069E6F0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F3A7 RID: 62375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F3A7")]
		[Address(RVA = "0x69E9A0", Offset = "0x69D5A0", VA = "0x18069E9A0")]
		private List<GridPosition> _GetTilesBetween(Entity target)
		{
			return null;
		}

		// Token: 0x0600F3A8 RID: 62376 RVA: 0x00059DD8 File Offset: 0x00057FD8
		[Token(Token = "0x600F3A8")]
		[Address(RVA = "0x69F0B0", Offset = "0x69DCB0", VA = "0x18069F0B0")]
		private float _SqrDistanceToLineSegment(Vector2 pos, Vector2 start, Vector2 end)
		{
			return 0f;
		}

		// Token: 0x0600F3A9 RID: 62377 RVA: 0x00059DF0 File Offset: 0x00057FF0
		[Token(Token = "0x600F3A9")]
		[Address(RVA = "0x69F2A0", Offset = "0x69DEA0", VA = "0x18069F2A0")]
		private bool _VerifyTileObstacle(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600F3AA RID: 62378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3AA")]
		[Address(RVA = "0x69F5D0", Offset = "0x69E1D0", VA = "0x18069F5D0")]
		public AdvancedSelectorWithNoObstacleToTarget()
		{
		}

		// Token: 0x0600F3AB RID: 62379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3AB")]
		[Address(RVA = "0x60C6F0", Offset = "0x60B2F0", VA = "0x18060C6F0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F3AC RID: 62380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3AC")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010DBF RID: 69055
		[Token(Token = "0x4010DBF")]
		private const float TILE_HALF_SIZE = 0.5f;

		// Token: 0x04010DC0 RID: 69056
		[Token(Token = "0x4010DC0")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("OBSTACLE")]
		private TileSelector.Options _options;

		// Token: 0x04010DC1 RID: 69057
		[Token(Token = "0x4010DC1")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("OBSTACLE")]
		private float _straightLineCheckWidth;

		// Token: 0x04010DC2 RID: 69058
		[Token(Token = "0x4010DC2")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		[Group("OBSTACLE")]
		private Vector2 _offset;

		// Token: 0x04010DC3 RID: 69059
		[Token(Token = "0x4010DC3")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		[Group("OBSTACLE")]
		private bool _checkEntityBlacklist;

		// Token: 0x04010DC4 RID: 69060
		[Token(Token = "0x4010DC4")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("OBSTACLE")]
		[Inspect("checkEntityBlacklist")]
		private List<string> _blacklistEntityIds;

		// Token: 0x04010DC5 RID: 69061
		[Token(Token = "0x4010DC5")]
		[FieldOffset(Offset = "0x150")]
		private float m_sqrCheckWidth;

		// Token: 0x04010DC6 RID: 69062
		[Token(Token = "0x4010DC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_checkEntityBlacklist;

		// Token: 0x04010DC7 RID: 69063
		[Token(Token = "0x4010DC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010DC8 RID: 69064
		[Token(Token = "0x4010DC8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010DC9 RID: 69065
		[Token(Token = "0x4010DC9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetTilesBetween;

		// Token: 0x04010DCA RID: 69066
		[Token(Token = "0x4010DCA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SqrDistanceToLineSegment;

		// Token: 0x04010DCB RID: 69067
		[Token(Token = "0x4010DCB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__VerifyTileObstacle;

		// Token: 0x04010DCC RID: 69068
		[Token(Token = "0x4010DCC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
