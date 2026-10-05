using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act29sign.View
{
	// Token: 0x02007490 RID: 29840
	[Token(Token = "0x2007490")]
	public class Act29signChoiceConfirmBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006335 RID: 25397
		// (get) Token: 0x0602A154 RID: 172372 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A155 RID: 172373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006335")]
		public Action<string> onClick
		{
			[Token(Token = "0x602A154")]
			[Address(RVA = "0x25B5250", Offset = "0x25B3E50", VA = "0x1825B5250")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602A155")]
			[Address(RVA = "0x25B52B0", Offset = "0x25B3EB0", VA = "0x1825B52B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602A156 RID: 172374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A156")]
		[Address(RVA = "0x25B5120", Offset = "0x25B3D20", VA = "0x1825B5120")]
		public void Render(string text, string btnOption)
		{
		}

		// Token: 0x0602A157 RID: 172375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A157")]
		[Address(RVA = "0x25B5010", Offset = "0x25B3C10", VA = "0x1825B5010")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602A158 RID: 172376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A158")]
		[Address(RVA = "0x25B51F0", Offset = "0x25B3DF0", VA = "0x1825B51F0")]
		public Act29signChoiceConfirmBtnView()
		{
		}

		// Token: 0x0403C688 RID: 247432
		[Token(Token = "0x403C688")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;

		// Token: 0x0403C689 RID: 247433
		[Token(Token = "0x403C689")]
		[FieldOffset(Offset = "0x20")]
		private string m_btnOption;

		// Token: 0x0403C68B RID: 247435
		[Token(Token = "0x403C68B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x0403C68C RID: 247436
		[Token(Token = "0x403C68C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0403C68D RID: 247437
		[Token(Token = "0x403C68D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C68E RID: 247438
		[Token(Token = "0x403C68E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403C68F RID: 247439
		[Token(Token = "0x403C68F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
