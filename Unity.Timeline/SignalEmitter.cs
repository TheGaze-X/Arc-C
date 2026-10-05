using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[CustomStyle("SignalEmitter")]
	[ExcludeFromPreset]
	[Serializable]
	public class SignalEmitter : Marker, INotification, INotificationOptionProvider
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000377C File Offset: 0x0000197C
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000BF")]
		public bool retroactive
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00003794 File Offset: 0x00001994
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000C0")]
		public bool emitOnce
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x1636A10", Offset = "0x1635610", VA = "0x181636A10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x1636A20", Offset = "0x1635620", VA = "0x181636A20")]
			set
			{
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000C1")]
		public SignalAsset asset
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000037AC File Offset: 0x000019AC
		[Token(Token = "0x170000C2")]
		private PropertyName id
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x58EC160", Offset = "0x58EAD60", VA = "0x1858EC160", Slot = "9")]
			get
			{
				return default(PropertyName);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000037C4 File Offset: 0x000019C4
		[Token(Token = "0x170000C3")]
		private NotificationFlags flags
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x58EC220", Offset = "0x58EAE20", VA = "0x1858EC220", Slot = "10")]
			get
			{
				return (NotificationFlags)0;
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public SignalEmitter()
		{
		}

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_Retroactive;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool m_EmitOnce;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SignalAsset m_Asset;
	}
}
