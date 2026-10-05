using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061B6 RID: 25014
	[Token(Token = "0x20061B6")]
	public class BossRushStageDetailCharCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602418B RID: 147851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602418B")]
		[Address(RVA = "0x1EC58E0", Offset = "0x1EC44E0", VA = "0x181EC58E0")]
		public void Render(string charId)
		{
		}

		// Token: 0x0602418C RID: 147852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602418C")]
		[Address(RVA = "0x1EC5D20", Offset = "0x1EC4920", VA = "0x181EC5D20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602418D RID: 147853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602418D")]
		[Address(RVA = "0x1EC5E40", Offset = "0x1EC4A40", VA = "0x181EC5E40")]
		public BossRushStageDetailCharCardView()
		{
		}

		// Token: 0x040322A8 RID: 205480
		[Token(Token = "0x40322A8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _characterPortraitBg;

		// Token: 0x040322A9 RID: 205481
		[Token(Token = "0x40322A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _characterPortraitContent;

		// Token: 0x040322AA RID: 205482
		[Token(Token = "0x40322AA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _charEmptyToggle;

		// Token: 0x040322AB RID: 205483
		[Token(Token = "0x40322AB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _charPortrait;

		// Token: 0x040322AC RID: 205484
		[Token(Token = "0x40322AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _charProfession;

		// Token: 0x040322AD RID: 205485
		[Token(Token = "0x40322AD")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x040322AE RID: 205486
		[Token(Token = "0x40322AE")]
		[FieldOffset(Offset = "0x48")]
		private BossRushStageDetailCharCardView.Adapter m_adapter;

		// Token: 0x040322AF RID: 205487
		[Token(Token = "0x40322AF")]
		[FieldOffset(Offset = "0x50")]
		private CharacterData m_cachedData;

		// Token: 0x040322B0 RID: 205488
		[Token(Token = "0x40322B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040322B1 RID: 205489
		[Token(Token = "0x40322B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040322B2 RID: 205490
		[Token(Token = "0x40322B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020061B7 RID: 25015
		[Token(Token = "0x20061B7")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602418E RID: 147854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602418E")]
			[Address(RVA = "0x1EB4480", Offset = "0x1EB3080", VA = "0x181EB4480")]
			public Adapter(BossRushStageDetailCharCardView closure)
			{
			}

			// Token: 0x1700552E RID: 21806
			// (get) Token: 0x0602418F RID: 147855 RVA: 0x000C3210 File Offset: 0x000C1410
			[Token(Token = "0x1700552E")]
			public override int count
			{
				[Token(Token = "0x602418F")]
				[Address(RVA = "0x1EB45E0", Offset = "0x1EB31E0", VA = "0x181EB45E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024190 RID: 147856 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024190")]
			[Address(RVA = "0x1EB3D60", Offset = "0x1EB2960", VA = "0x181EB3D60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040322B3 RID: 205491
			[Token(Token = "0x40322B3")]
			[FieldOffset(Offset = "0x20")]
			private BossRushStageDetailCharCardView m_closure;

			// Token: 0x040322B4 RID: 205492
			[Token(Token = "0x40322B4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040322B5 RID: 205493
			[Token(Token = "0x40322B5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040322B6 RID: 205494
			[Token(Token = "0x40322B6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
