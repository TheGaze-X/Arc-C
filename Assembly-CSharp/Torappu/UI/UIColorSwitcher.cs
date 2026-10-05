using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039DC RID: 14812
	[Token(Token = "0x20039DC")]
	public abstract class UIColorSwitcher<ColorType> : MonoBehaviour, IHotfixable where ColorType : struct, IConvertible, IComparable
	{
		// Token: 0x06017645 RID: 95813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017645")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017646 RID: 95814
		[Token(Token = "0x6017646")]
		protected abstract void OnInitDefines(Action<ColorType, Color> addCase);

		// Token: 0x06017647 RID: 95815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017647")]
		private void _ApplyColor(Color clr, bool immediately)
		{
		}

		// Token: 0x06017648 RID: 95816 RVA: 0x00096480 File Offset: 0x00094680
		[Token(Token = "0x6017648")]
		private bool _DoSwitch(ColorType type, bool immediately)
		{
			return default(bool);
		}

		// Token: 0x06017649 RID: 95817 RVA: 0x00096498 File Offset: 0x00094698
		[Token(Token = "0x6017649")]
		public bool Swtich(ColorType type, bool immediately)
		{
			return default(bool);
		}

		// Token: 0x0601764A RID: 95818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601764A")]
		public void ModifyColor(ColorType type, Color clr)
		{
		}

		// Token: 0x0601764B RID: 95819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601764B")]
		private void Awake()
		{
		}

		// Token: 0x0601764C RID: 95820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601764C")]
		protected UIColorSwitcher()
		{
		}

		// Token: 0x0401C3FB RID: 115707
		[Token(Token = "0x401C3FB")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Graphic[] _targets;

		// Token: 0x0401C3FC RID: 115708
		[Token(Token = "0x401C3FC")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float _duration;

		// Token: 0x0401C3FD RID: 115709
		[Token(Token = "0x401C3FD")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Tooltip("preferred when alpha change")]
		private bool _alwaysImmediately;

		// Token: 0x0401C3FE RID: 115710
		[Token(Token = "0x401C3FE")]
		[FieldOffset(Offset = "0x0")]
		private ListDict<ColorType, Color> m_typeColors;

		// Token: 0x0401C3FF RID: 115711
		[Token(Token = "0x401C3FF")]
		[FieldOffset(Offset = "0x0")]
		private ColorType m_currType;

		// Token: 0x0401C400 RID: 115712
		[Token(Token = "0x401C400")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C401 RID: 115713
		[Token(Token = "0x401C401")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ApplyColor;

		// Token: 0x0401C402 RID: 115714
		[Token(Token = "0x401C402")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__DoSwitch;

		// Token: 0x0401C403 RID: 115715
		[Token(Token = "0x401C403")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Swtich;

		// Token: 0x0401C404 RID: 115716
		[Token(Token = "0x401C404")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ModifyColor;

		// Token: 0x0401C405 RID: 115717
		[Token(Token = "0x401C405")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401C406 RID: 115718
		[Token(Token = "0x401C406")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
