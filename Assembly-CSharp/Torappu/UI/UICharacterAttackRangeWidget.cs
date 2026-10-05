using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003527 RID: 13607
	[Token(Token = "0x2003527")]
	[RequireComponent(typeof(GridLayoutGroup))]
	public class UICharacterAttackRangeWidget : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x06015AFD RID: 88829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003385")]
		protected GridLayoutGroup grid
		{
			[Token(Token = "0x6015AFD")]
			[Address(RVA = "0xE484D0", Offset = "0xE470D0", VA = "0x180E484D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015AFE RID: 88830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AFE")]
		[Address(RVA = "0xE47EA0", Offset = "0xE46AA0", VA = "0x180E47EA0")]
		public void RenderAttackRange(AttackRangeDescModel attackRange)
		{
		}

		// Token: 0x06015AFF RID: 88831 RVA: 0x0008D768 File Offset: 0x0008B968
		[Token(Token = "0x6015AFF")]
		[Address(RVA = "0xE483C0", Offset = "0xE46FC0", VA = "0x180E483C0")]
		private bool _CheckIfRangeDirty(AttackRangeDescModel attackRange)
		{
			return default(bool);
		}

		// Token: 0x06015B00 RID: 88832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B00")]
		[Address(RVA = "0xE48470", Offset = "0xE47070", VA = "0x180E48470")]
		public UICharacterAttackRangeWidget()
		{
		}

		// Token: 0x0401A0A1 RID: 106657
		[Token(Token = "0x401A0A1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Sprite _tileEmpty;

		// Token: 0x0401A0A2 RID: 106658
		[Token(Token = "0x401A0A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Sprite _tileStand;

		// Token: 0x0401A0A3 RID: 106659
		[Token(Token = "0x401A0A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Sprite _tileAttack;

		// Token: 0x0401A0A4 RID: 106660
		[Token(Token = "0x401A0A4")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedRangeId;

		// Token: 0x0401A0A5 RID: 106661
		[Token(Token = "0x401A0A5")]
		[FieldOffset(Offset = "0x38")]
		protected GridLayoutGroup m_grid;

		// Token: 0x0401A0A6 RID: 106662
		[Token(Token = "0x401A0A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_grid;

		// Token: 0x0401A0A7 RID: 106663
		[Token(Token = "0x401A0A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderAttackRange;

		// Token: 0x0401A0A8 RID: 106664
		[Token(Token = "0x401A0A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfRangeDirty;

		// Token: 0x0401A0A9 RID: 106665
		[Token(Token = "0x401A0A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
