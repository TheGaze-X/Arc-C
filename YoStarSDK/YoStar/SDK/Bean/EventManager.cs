using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YoStar.SDK.Bean
{
	// Token: 0x020002A0 RID: 672
	[Token(Token = "0x20002A0")]
	public class EventManager
	{
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000FB2 RID: 4018 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000FB3 RID: 4019 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000015")]
		public static event Action OnUserDetailDataChanged
		{
			[Token(Token = "0x6000FB2")]
			[Address(RVA = "0x5CBC060", Offset = "0x5CBAC60", VA = "0x185CBC060")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FB3")]
			[Address(RVA = "0x5CBC200", Offset = "0x5CBAE00", VA = "0x185CBC200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000FB4 RID: 4020 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x06000FB5 RID: 4021 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000016")]
		public static event Action<List<string>> OnLoginHistoryChanged
		{
			[Token(Token = "0x6000FB4")]
			[Address(RVA = "0x5CBBF80", Offset = "0x5CBAB80", VA = "0x185CBBF80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FB5")]
			[Address(RVA = "0x5CBC120", Offset = "0x5CBAD20", VA = "0x185CBC120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0x5CBBF30", Offset = "0x5CBAB30", VA = "0x185CBBF30")]
		public static void TriggerUserDetailDataChanged()
		{
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x5CBBED0", Offset = "0x5CBAAD0", VA = "0x185CBBED0")]
		public static void TriggerLoginHistoryChanged(List<string> data)
		{
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EventManager()
		{
		}
	}
}
