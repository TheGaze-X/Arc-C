using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Audio.Middleware.Data;
using UnityEngine;

namespace Torappu.Audio.Middleware
{
	// Token: 0x02001FB6 RID: 8118
	[Token(Token = "0x2001FB6")]
	public class TorappuAudioMiddleware : AudioMiddleware
	{
		// Token: 0x0600C99D RID: 51613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C99D")]
		[Address(RVA = "0x34B49D0", Offset = "0x34B35D0", VA = "0x1834B49D0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600C99E RID: 51614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C99E")]
		[Address(RVA = "0x34B5030", Offset = "0x34B3C30", VA = "0x1834B5030", Slot = "5")]
		public override void ReloadBanks()
		{
		}

		// Token: 0x0600C99F RID: 51615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C99F")]
		[Address(RVA = "0x34B5460", Offset = "0x34B4060", VA = "0x1834B5460")]
		private void _ReloadBanksImpl()
		{
		}

		// Token: 0x0600C9A0 RID: 51616 RVA: 0x00049308 File Offset: 0x00047508
		[Token(Token = "0x600C9A0")]
		[Address(RVA = "0x34B4D10", Offset = "0x34B3910", VA = "0x1834B4D10", Slot = "6")]
		public override bool PlayEvent(string eventName, Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x0600C9A1 RID: 51617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9A1")]
		[Address(RVA = "0x34B4A80", Offset = "0x34B3680", VA = "0x1834B4A80", Slot = "7")]
		public override void PlayEvent(string eventName, Vector3 position, out AudioAtom[] atoms)
		{
		}

		// Token: 0x0600C9A2 RID: 51618 RVA: 0x00049320 File Offset: 0x00047520
		[Token(Token = "0x600C9A2")]
		[Address(RVA = "0x34B5200", Offset = "0x34B3E00", VA = "0x1834B5200", Slot = "8")]
		public override bool TestEvent(string eventName)
		{
			return default(bool);
		}

		// Token: 0x0600C9A3 RID: 51619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9A3")]
		[Address(RVA = "0x34B4EB0", Offset = "0x34B3AB0", VA = "0x1834B4EB0", Slot = "9")]
		public override void PreloadEvent(string persistTag, string eventName)
		{
		}

		// Token: 0x0600C9A4 RID: 51620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9A4")]
		[Address(RVA = "0x34B53A0", Offset = "0x34B3FA0", VA = "0x1834B53A0", Slot = "11")]
		public override void UnloadPreloadedAssets(string persistTag)
		{
		}

		// Token: 0x0600C9A5 RID: 51621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9A5")]
		[Address(RVA = "0x34B51F0", Offset = "0x34B3DF0", VA = "0x1834B51F0", Slot = "12")]
		public override void StopPreloadedEvents(string persistTag)
		{
		}

		// Token: 0x0600C9A6 RID: 51622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9A6")]
		[Address(RVA = "0x34B50D0", Offset = "0x34B3CD0", VA = "0x1834B50D0", Slot = "10")]
		public override void SetListenerPosition(Vector3 worldPosition, Quaternion worldRotation)
		{
		}

		// Token: 0x0600C9A7 RID: 51623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9A7")]
		[Address(RVA = "0x34B53B0", Offset = "0x34B3FB0", VA = "0x1834B53B0", Slot = "13")]
		public override void Update(float deltaTime)
		{
		}

		// Token: 0x0600C9A8 RID: 51624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9A8")]
		[Address(RVA = "0x34B5110", Offset = "0x34B3D10", VA = "0x1834B5110", Slot = "14")]
		public override void StopAll(float fadeTime, bool exceptMusic)
		{
		}

		// Token: 0x0600C9A9 RID: 51625 RVA: 0x00049338 File Offset: 0x00047538
		[Token(Token = "0x600C9A9")]
		[Address(RVA = "0x34B52D0", Offset = "0x34B3ED0", VA = "0x1834B52D0")]
		public bool TryGetBankList(string nameOrAlias, out List<Bank> bankList)
		{
			return default(bool);
		}

		// Token: 0x0600C9AA RID: 51626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9AA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TorappuAudioMiddleware()
		{
		}

		// Token: 0x0400D20B RID: 53771
		[Token(Token = "0x400D20B")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, List<Bank>> m_banks;

		// Token: 0x0400D20C RID: 53772
		[Token(Token = "0x400D20C")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, string> m_bankAlias;

		// Token: 0x0400D20D RID: 53773
		[Token(Token = "0x400D20D")]
		[FieldOffset(Offset = "0x20")]
		private Bank[] m_bankList;
	}
}
