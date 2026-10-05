using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E3C RID: 7740
	[Token(Token = "0x2001E3C")]
	public class AnimatedTextStampView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x0600BFAC RID: 49068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700172B")]
		public string stampId
		{
			[Token(Token = "0x600BFAC")]
			[Address(RVA = "0x33E7160", Offset = "0x33E5D60", VA = "0x1833E7160")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BFAD RID: 49069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFAD")]
		[Address(RVA = "0x33E6CE0", Offset = "0x33E58E0", VA = "0x1833E6CE0")]
		public void InitView(AVGDisplayableExecutor.CmdParam param, [Optional] Action cb)
		{
		}

		// Token: 0x0600BFAE RID: 49070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFAE")]
		[Address(RVA = "0x33E6C80", Offset = "0x33E5880", VA = "0x1833E6C80")]
		public void Dismiss()
		{
		}

		// Token: 0x0600BFAF RID: 49071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFAF")]
		[Address(RVA = "0x33E7100", Offset = "0x33E5D00", VA = "0x1833E7100")]
		public AnimatedTextStampView()
		{
		}

		// Token: 0x0400C0DA RID: 49370
		[Token(Token = "0x400C0DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text[] _textArray;

		// Token: 0x0400C0DB RID: 49371
		[Token(Token = "0x400C0DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0400C0DC RID: 49372
		[Token(Token = "0x400C0DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _animationName;

		// Token: 0x0400C0DD RID: 49373
		[Token(Token = "0x400C0DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_stampId;

		// Token: 0x0400C0DE RID: 49374
		[Token(Token = "0x400C0DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stampId;

		// Token: 0x0400C0DF RID: 49375
		[Token(Token = "0x400C0DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitView;

		// Token: 0x0400C0E0 RID: 49376
		[Token(Token = "0x400C0E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Dismiss;

		// Token: 0x0400C0E1 RID: 49377
		[Token(Token = "0x400C0E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
