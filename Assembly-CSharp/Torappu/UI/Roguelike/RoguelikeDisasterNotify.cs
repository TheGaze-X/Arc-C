using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051FA RID: 20986
	[Token(Token = "0x20051FA")]
	public class RoguelikeDisasterNotify : RoguelikeAnimNotify
	{
		// Token: 0x1700485A RID: 18522
		// (get) Token: 0x0601EFB8 RID: 126904 RVA: 0x000B0508 File Offset: 0x000AE708
		[Token(Token = "0x1700485A")]
		public override RoguelikeCustomNotifyType notifyType
		{
			[Token(Token = "0x601EFB8")]
			[Address(RVA = "0x18B5050", Offset = "0x18B3C50", VA = "0x1818B5050", Slot = "4")]
			get
			{
				return RoguelikeCustomNotifyType.NONE;
			}
		}

		// Token: 0x0601EFB9 RID: 126905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EFB9")]
		[Address(RVA = "0x18B4DB0", Offset = "0x18B39B0", VA = "0x1818B4DB0", Slot = "7")]
		protected override void Render(ValueBundle options)
		{
		}

		// Token: 0x0601EFBA RID: 126906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EFBA")]
		[Address(RVA = "0x18B4F70", Offset = "0x18B3B70", VA = "0x1818B4F70")]
		public RoguelikeDisasterNotify()
		{
		}

		// Token: 0x04029942 RID: 170306
		[Token(Token = "0x4029942")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _disasterIcon;

		// Token: 0x04029943 RID: 170307
		[Token(Token = "0x4029943")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtDisasterName;

		// Token: 0x04029944 RID: 170308
		[Token(Token = "0x4029944")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _levelLines;

		// Token: 0x04029945 RID: 170309
		[Token(Token = "0x4029945")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_notifyType;

		// Token: 0x04029946 RID: 170310
		[Token(Token = "0x4029946")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029947 RID: 170311
		[Token(Token = "0x4029947")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051FB RID: 20987
		[Token(Token = "0x20051FB")]
		public class Param
		{
			// Token: 0x0601EFBB RID: 126907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EFBB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04029948 RID: 170312
			[Token(Token = "0x4029948")]
			[FieldOffset(Offset = "0x10")]
			public string disasterName;

			// Token: 0x04029949 RID: 170313
			[Token(Token = "0x4029949")]
			[FieldOffset(Offset = "0x18")]
			public Sprite disasterIcon;

			// Token: 0x0402994A RID: 170314
			[Token(Token = "0x402994A")]
			[FieldOffset(Offset = "0x20")]
			public int disasterLevel;
		}
	}
}
