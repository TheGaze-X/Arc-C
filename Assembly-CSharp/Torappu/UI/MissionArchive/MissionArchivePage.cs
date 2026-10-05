using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x0200484B RID: 18507
	[Token(Token = "0x200484B")]
	public class MissionArchivePage : UIPage, IHotfixable
	{
		// Token: 0x0601BF51 RID: 114513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF51")]
		[Address(RVA = "0x1551B30", Offset = "0x1550730", VA = "0x181551B30", Slot = "8")]
		protected override void OnCreate(DataBundle savedInstance)
		{
		}

		// Token: 0x0601BF52 RID: 114514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF52")]
		[Address(RVA = "0x1551BA0", Offset = "0x15507A0", VA = "0x181551BA0", Slot = "9")]
		protected override void OnReuse(DataBundle savedInstance)
		{
		}

		// Token: 0x0601BF53 RID: 114515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF53")]
		[Address(RVA = "0x1551C10", Offset = "0x1550810", VA = "0x181551C10", Slot = "12")]
		public override IEnumerator ShowCoroutine(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0601BF54 RID: 114516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF54")]
		[Address(RVA = "0x1551A50", Offset = "0x1550650", VA = "0x181551A50", Slot = "13")]
		protected override IEnumerator HideCoroutine(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0601BF55 RID: 114517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF55")]
		[Address(RVA = "0x1551CE0", Offset = "0x15508E0", VA = "0x181551CE0")]
		private void _LoadContentIfNeed()
		{
		}

		// Token: 0x0601BF56 RID: 114518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF56")]
		[Address(RVA = "0x1552030", Offset = "0x1550C30", VA = "0x181552030")]
		public MissionArchivePage()
		{
		}

		// Token: 0x0601BF57 RID: 114519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF57")]
		[Address(RVA = "0xE98770", Offset = "0xE97370", VA = "0x180E98770")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601BF58 RID: 114520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF58")]
		[Address(RVA = "0x1551CD0", Offset = "0x15508D0", VA = "0x181551CD0")]
		private void <>xLuaBaseProxy_OnReuse(DataBundle P0)
		{
		}

		// Token: 0x0601BF59 RID: 114521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF59")]
		[Address(RVA = "0xE987B0", Offset = "0xE973B0", VA = "0x180E987B0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(bool P0)
		{
			return null;
		}

		// Token: 0x0601BF5A RID: 114522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF5A")]
		[Address(RVA = "0xE98760", Offset = "0xE97360", VA = "0x180E98760")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0402475B RID: 149339
		[Token(Token = "0x402475B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Transform _controllerContainer;

		// Token: 0x0402475C RID: 149340
		[Token(Token = "0x402475C")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Transform _rtContentContainer;

		// Token: 0x0402475D RID: 149341
		[Token(Token = "0x402475D")]
		[FieldOffset(Offset = "0xE8")]
		private string m_cachedTopicId;

		// Token: 0x0402475E RID: 149342
		[Token(Token = "0x402475E")]
		[FieldOffset(Offset = "0xF0")]
		private MissionArchiveController m_controller;

		// Token: 0x0402475F RID: 149343
		[Token(Token = "0x402475F")]
		[FieldOffset(Offset = "0xF8")]
		private GameObject m_rtContent;

		// Token: 0x04024760 RID: 149344
		[Token(Token = "0x4024760")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04024761 RID: 149345
		[Token(Token = "0x4024761")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReuse;

		// Token: 0x04024762 RID: 149346
		[Token(Token = "0x4024762")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04024763 RID: 149347
		[Token(Token = "0x4024763")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04024764 RID: 149348
		[Token(Token = "0x4024764")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadContentIfNeed;

		// Token: 0x04024765 RID: 149349
		[Token(Token = "0x4024765")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200484C RID: 18508
		[Token(Token = "0x200484C")]
		public class Params
		{
			// Token: 0x0601BF5B RID: 114523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BF5B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04024766 RID: 149350
			[Token(Token = "0x4024766")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;
		}
	}
}
