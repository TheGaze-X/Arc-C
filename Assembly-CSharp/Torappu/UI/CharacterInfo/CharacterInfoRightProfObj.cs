using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F9A RID: 24474
	[Token(Token = "0x2005F9A")]
	public abstract class CharacterInfoRightProfObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700539E RID: 21406
		// (get) Token: 0x06023689 RID: 145033 RVA: 0x000C0BE8 File Offset: 0x000BEDE8
		[Token(Token = "0x1700539E")]
		protected float height
		{
			[Token(Token = "0x6023689")]
			[Address(RVA = "0x1E06AF0", Offset = "0x1E056F0", VA = "0x181E06AF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0602368A RID: 145034
		[Token(Token = "0x602368A")]
		public abstract float GetAndApplyHeight();

		// Token: 0x0602368B RID: 145035 RVA: 0x000C0C00 File Offset: 0x000BEE00
		[Token(Token = "0x602368B")]
		[Address(RVA = "0x1E030C0", Offset = "0x1E01CC0", VA = "0x181E030C0", Slot = "5")]
		public virtual bool CheckAvailInfo(CharacterInfoHolderBean.CharViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0602368C RID: 145036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602368C")]
		[Address(RVA = "0x1E03130", Offset = "0x1E01D30", VA = "0x181E03130", Slot = "6")]
		public virtual void Render(CharacterInfoHolderBean.CharViewModel viewModel)
		{
		}

		// Token: 0x0602368D RID: 145037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602368D")]
		[Address(RVA = "0x1E06A90", Offset = "0x1E05690", VA = "0x181E06A90")]
		protected CharacterInfoRightProfObj()
		{
		}

		// Token: 0x04030EC4 RID: 200388
		[Token(Token = "0x4030EC4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _height;

		// Token: 0x04030EC5 RID: 200389
		[Token(Token = "0x4030EC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_height;

		// Token: 0x04030EC6 RID: 200390
		[Token(Token = "0x4030EC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckAvailInfo;

		// Token: 0x04030EC7 RID: 200391
		[Token(Token = "0x4030EC7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030EC8 RID: 200392
		[Token(Token = "0x4030EC8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
