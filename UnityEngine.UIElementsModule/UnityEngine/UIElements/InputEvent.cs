using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001AB RID: 427
	[Token(Token = "0x20001AB")]
	public class InputEvent : EventBase<InputEvent>
	{
		// Token: 0x17000289 RID: 649
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000289")]
		protected string previousData
		{
			[Token(Token = "0x6000BA5")]
			[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700028A RID: 650
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028A")]
		protected string newData
		{
			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x168B8E0", Offset = "0x168A4E0", VA = "0x18168B8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x5ADE6A0", Offset = "0x5ADD2A0", VA = "0x185ADE6A0", Slot = "12")]
		protected override void Init()
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x5ADE710", Offset = "0x5ADD310", VA = "0x185ADE710")]
		private void LocalInit()
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x5ADE5F0", Offset = "0x5ADD1F0", VA = "0x185ADE5F0")]
		public static InputEvent GetPooled(string previousData, string newData)
		{
			return null;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x5ADE750", Offset = "0x5ADD350", VA = "0x185ADE750")]
		public InputEvent()
		{
		}
	}
}
