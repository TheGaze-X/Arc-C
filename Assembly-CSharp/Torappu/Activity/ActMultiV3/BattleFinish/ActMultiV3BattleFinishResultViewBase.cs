using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x02007096 RID: 28822
	[Token(Token = "0x2007096")]
	public abstract class ActMultiV3BattleFinishResultViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x170060E8 RID: 24808
		// (get) Token: 0x06028F27 RID: 167719
		[Token(Token = "0x170060E8")]
		public abstract ActMultiV3MapModeType modeType { [Token(Token = "0x6028F27")] get; }

		// Token: 0x06028F28 RID: 167720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F28")]
		[Address(RVA = "0x2450600", Offset = "0x244F200", VA = "0x182450600")]
		public void Render(ActMultiV3BattleFinishViewModel viewModel)
		{
		}

		// Token: 0x06028F29 RID: 167721
		[Token(Token = "0x6028F29")]
		protected abstract void OnRender();

		// Token: 0x06028F2A RID: 167722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F2A")]
		[Address(RVA = "0x2450800", Offset = "0x244F400", VA = "0x182450800")]
		protected ActMultiV3BattleFinishResultViewBase()
		{
		}

		// Token: 0x0403A6FF RID: 239359
		[Token(Token = "0x403A6FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _rootGO;

		// Token: 0x0403A700 RID: 239360
		[Token(Token = "0x403A700")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _activeStarGOList;

		// Token: 0x0403A701 RID: 239361
		[Token(Token = "0x403A701")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _inactiveStarGOList;

		// Token: 0x0403A702 RID: 239362
		[Token(Token = "0x403A702")]
		[FieldOffset(Offset = "0x30")]
		protected ActMultiV3BattleFinishViewModel m_viewModel;

		// Token: 0x0403A703 RID: 239363
		[Token(Token = "0x403A703")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A704 RID: 239364
		[Token(Token = "0x403A704")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
