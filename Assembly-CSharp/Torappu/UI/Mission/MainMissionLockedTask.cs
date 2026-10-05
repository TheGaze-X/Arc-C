using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x0200488E RID: 18574
	[Token(Token = "0x200488E")]
	public class MainMissionLockedTask : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C09C RID: 114844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C09C")]
		[Address(RVA = "0x1565720", Offset = "0x1564320", VA = "0x181565720")]
		public MainMissionLockedTask()
		{
		}

		// Token: 0x04024984 RID: 149892
		[Token(Token = "0x4024984")]
		private const float LOCKED_BAR_HEIGHT = 150f;

		// Token: 0x04024985 RID: 149893
		[Token(Token = "0x4024985")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200488F RID: 18575
		[Token(Token = "0x200488F")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<MainMissionLockedTask>
		{
			// Token: 0x0601C09D RID: 114845 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C09D")]
			[Address(RVA = "0x1577440", Offset = "0x1576040", VA = "0x181577440", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601C09E RID: 114846 RVA: 0x000A7070 File Offset: 0x000A5270
			[Token(Token = "0x601C09E")]
			[Address(RVA = "0x15774B0", Offset = "0x15760B0", VA = "0x1815774B0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601C09F RID: 114847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C09F")]
			[Address(RVA = "0x15775B0", Offset = "0x15761B0", VA = "0x1815775B0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0601C0A0 RID: 114848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C0A0")]
			[Address(RVA = "0x15776D0", Offset = "0x15762D0", VA = "0x1815776D0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0601C0A1 RID: 114849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C0A1")]
			[Address(RVA = "0x1577790", Offset = "0x1576390", VA = "0x181577790")]
			public VirtualView()
			{
			}

			// Token: 0x04024986 RID: 149894
			[Token(Token = "0x4024986")]
			[FieldOffset(Offset = "0x20")]
			public MainMissionLockedTask prefab;

			// Token: 0x04024987 RID: 149895
			[Token(Token = "0x4024987")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04024988 RID: 149896
			[Token(Token = "0x4024988")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x04024989 RID: 149897
			[Token(Token = "0x4024989")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402498A RID: 149898
			[Token(Token = "0x402498A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402498B RID: 149899
			[Token(Token = "0x402498B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
