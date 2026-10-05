using System;
using Il2CppDummyDll;
using Torappu.Audio.Engine;
using UnityEngine;
using XLua;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FBA RID: 8122
	[Token(Token = "0x2001FBA")]
	[Serializable]
	public class BGMBank : Bank, IMusicInfo, IAudioInfo, IAliasBank
	{
		// Token: 0x0600C9BC RID: 51644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9BC")]
		[Address(RVA = "0x34A58D0", Offset = "0x34A44D0", VA = "0x1834A58D0", Slot = "8")]
		public string GetIntroAsset()
		{
			return null;
		}

		// Token: 0x0600C9BD RID: 51645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9BD")]
		[Address(RVA = "0x34A5940", Offset = "0x34A4540", VA = "0x1834A5940", Slot = "9")]
		public string GetLoopAsset()
		{
			return null;
		}

		// Token: 0x0600C9BE RID: 51646 RVA: 0x00049398 File Offset: 0x00047598
		[Token(Token = "0x600C9BE")]
		[Address(RVA = "0x34A59B0", Offset = "0x34A45B0", VA = "0x1834A59B0", Slot = "10")]
		public bool IsSameAudio(IAudioInfo other)
		{
			return default(bool);
		}

		// Token: 0x0600C9BF RID: 51647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9BF")]
		[Address(RVA = "0x34A5A40", Offset = "0x34A4640", VA = "0x1834A5A40", Slot = "4")]
		public override AudioAtom Play(Vector3 position)
		{
			return null;
		}

		// Token: 0x0600C9C0 RID: 51648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9C0")]
		[Address(RVA = "0x34A5D20", Offset = "0x34A4920", VA = "0x1834A5D20", Slot = "5")]
		public override void Preload(string persistTag)
		{
		}

		// Token: 0x0600C9C1 RID: 51649 RVA: 0x000493B0 File Offset: 0x000475B0
		[Token(Token = "0x600C9C1")]
		[Address(RVA = "0x34A5F60", Offset = "0x34A4B60", VA = "0x1834A5F60")]
		public bool ShouldSerializefadeStyleId()
		{
			return default(bool);
		}

		// Token: 0x0600C9C2 RID: 51650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9C2")]
		[Address(RVA = "0x34A56C0", Offset = "0x34A42C0", VA = "0x1834A56C0", Slot = "11")]
		public string GenerateSignature()
		{
			return null;
		}

		// Token: 0x0600C9C3 RID: 51651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9C3")]
		[Address(RVA = "0x34A5E60", Offset = "0x34A4A60", VA = "0x1834A5E60")]
		public BGMBank ShallowClone()
		{
			return null;
		}

		// Token: 0x0600C9C4 RID: 51652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9C4")]
		[Address(RVA = "0x34A6160", Offset = "0x34A4D60", VA = "0x1834A6160")]
		public BGMBank()
		{
		}

		// Token: 0x0600C9C6 RID: 51654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9C6")]
		[Address(RVA = "0x34A5FE0", Offset = "0x34A4BE0", VA = "0x1834A5FE0")]
		private void <>xLuaBaseProxy_Preload(string P0)
		{
		}

		// Token: 0x0400D220 RID: 53792
		[Token(Token = "0x400D220")]
		[FieldOffset(Offset = "0x0")]
		private static BGMAudioAtom m_bgmAtom;

		// Token: 0x0400D221 RID: 53793
		[Token(Token = "0x400D221")]
		private const string FLOAT_FORMAT = "#{0:0.###}";

		// Token: 0x0400D222 RID: 53794
		[Token(Token = "0x400D222")]
		[FieldOffset(Offset = "0x30")]
		public string intro;

		// Token: 0x0400D223 RID: 53795
		[Token(Token = "0x400D223")]
		[FieldOffset(Offset = "0x38")]
		public string loop;

		// Token: 0x0400D224 RID: 53796
		[Token(Token = "0x400D224")]
		[FieldOffset(Offset = "0x40")]
		public float volume;

		// Token: 0x0400D225 RID: 53797
		[Token(Token = "0x400D225")]
		[FieldOffset(Offset = "0x44")]
		public float crossfade;

		// Token: 0x0400D226 RID: 53798
		[Token(Token = "0x400D226")]
		[FieldOffset(Offset = "0x48")]
		public float delay;

		// Token: 0x0400D227 RID: 53799
		[Token(Token = "0x400D227")]
		[FieldOffset(Offset = "0x50")]
		public string fadeStyleId;

		// Token: 0x0400D228 RID: 53800
		[Token(Token = "0x400D228")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetIntroAsset;

		// Token: 0x0400D229 RID: 53801
		[Token(Token = "0x400D229")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetLoopAsset;

		// Token: 0x0400D22A RID: 53802
		[Token(Token = "0x400D22A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsSameAudio;

		// Token: 0x0400D22B RID: 53803
		[Token(Token = "0x400D22B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0400D22C RID: 53804
		[Token(Token = "0x400D22C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Preload;

		// Token: 0x0400D22D RID: 53805
		[Token(Token = "0x400D22D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShouldSerializefadeStyleId;

		// Token: 0x0400D22E RID: 53806
		[Token(Token = "0x400D22E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GenerateSignature;

		// Token: 0x0400D22F RID: 53807
		[Token(Token = "0x400D22F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShallowClone;

		// Token: 0x0400D230 RID: 53808
		[Token(Token = "0x400D230")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
