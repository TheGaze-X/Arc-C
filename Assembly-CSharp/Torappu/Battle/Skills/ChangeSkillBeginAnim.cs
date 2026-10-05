using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Skills
{
	// Token: 0x020028B0 RID: 10416
	[Token(Token = "0x20028B0")]
	public class ChangeSkillBeginAnim : BasicSkill.Behaviour
	{
		// Token: 0x06011521 RID: 70945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011521")]
		[Address(RVA = "0x91E7E0", Offset = "0x91D3E0", VA = "0x18091E7E0", Slot = "15")]
		public override void OnBeforePlayBeginAnim()
		{
		}

		// Token: 0x06011522 RID: 70946 RVA: 0x0006AA58 File Offset: 0x00068C58
		[Token(Token = "0x6011522")]
		[Address(RVA = "0x91E640", Offset = "0x91D240", VA = "0x18091E640")]
		private bool CheckBuffs(string[] buffKeys, ChangeSkillBeginAnim.CheckType checkType)
		{
			return default(bool);
		}

		// Token: 0x06011523 RID: 70947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011523")]
		[Address(RVA = "0x91EAE0", Offset = "0x91D6E0", VA = "0x18091EAE0")]
		public ChangeSkillBeginAnim()
		{
		}

		// Token: 0x06011524 RID: 70948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011524")]
		[Address(RVA = "0x91EAD0", Offset = "0x91D6D0", VA = "0x18091EAD0")]
		private void <>xLuaBaseProxy_OnBeforePlayBeginAnim()
		{
		}

		// Token: 0x040135A3 RID: 79267
		[Token(Token = "0x40135A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ChangeSkillBeginAnim.AnimInfo[] _animInfos;

		// Token: 0x040135A4 RID: 79268
		[Token(Token = "0x40135A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBeforePlayBeginAnim;

		// Token: 0x040135A5 RID: 79269
		[Token(Token = "0x40135A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckBuffs;

		// Token: 0x040135A6 RID: 79270
		[Token(Token = "0x40135A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020028B1 RID: 10417
		[Token(Token = "0x20028B1")]
		[Serializable]
		public struct AnimInfo
		{
			// Token: 0x040135A7 RID: 79271
			[Token(Token = "0x40135A7")]
			[FieldOffset(Offset = "0x0")]
			public string beginAnim;

			// Token: 0x040135A8 RID: 79272
			[Token(Token = "0x40135A8")]
			[FieldOffset(Offset = "0x8")]
			public string beginAnimDown;

			// Token: 0x040135A9 RID: 79273
			[Token(Token = "0x40135A9")]
			[FieldOffset(Offset = "0x10")]
			public string loopAnim;

			// Token: 0x040135AA RID: 79274
			[Token(Token = "0x40135AA")]
			[FieldOffset(Offset = "0x18")]
			public string endAnim;

			// Token: 0x040135AB RID: 79275
			[Token(Token = "0x40135AB")]
			[FieldOffset(Offset = "0x20")]
			public string[] buffKeys;

			// Token: 0x040135AC RID: 79276
			[Token(Token = "0x40135AC")]
			[FieldOffset(Offset = "0x28")]
			public ChangeSkillBeginAnim.CheckType checkType;
		}

		// Token: 0x020028B2 RID: 10418
		[Token(Token = "0x20028B2")]
		[Serializable]
		public enum CheckType
		{
			// Token: 0x040135AE RID: 79278
			[Token(Token = "0x40135AE")]
			No,
			// Token: 0x040135AF RID: 79279
			[Token(Token = "0x40135AF")]
			Any,
			// Token: 0x040135B0 RID: 79280
			[Token(Token = "0x40135B0")]
			All
		}
	}
}
