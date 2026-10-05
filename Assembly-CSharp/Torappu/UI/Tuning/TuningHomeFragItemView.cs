using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C9F RID: 15519
	[Token(Token = "0x2003C9F")]
	public class TuningHomeFragItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018398 RID: 99224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018398")]
		[Address(RVA = "0x10B7DD0", Offset = "0x10B69D0", VA = "0x1810B7DD0")]
		public void Render(TuningHomeFragItemViewModel fragModel)
		{
		}

		// Token: 0x06018399 RID: 99225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018399")]
		[Address(RVA = "0x10B7EF0", Offset = "0x10B6AF0", VA = "0x1810B7EF0")]
		public TuningHomeFragItemView()
		{
		}

		// Token: 0x0401D846 RID: 120902
		[Token(Token = "0x401D846")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0401D847 RID: 120903
		[Token(Token = "0x401D847")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0401D848 RID: 120904
		[Token(Token = "0x401D848")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D849 RID: 120905
		[Token(Token = "0x401D849")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D84A RID: 120906
		[Token(Token = "0x401D84A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
