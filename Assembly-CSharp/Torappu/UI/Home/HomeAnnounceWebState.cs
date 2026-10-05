using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Lua;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B02 RID: 19202
	[Token(Token = "0x2004B02")]
	public class HomeAnnounceWebState : UIWebWindowState
	{
		// Token: 0x0601CD83 RID: 118147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD83")]
		[Address(RVA = "0x163B200", Offset = "0x1639E00", VA = "0x18163B200", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CD84 RID: 118148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD84")]
		[Address(RVA = "0x163B3A0", Offset = "0x1639FA0", VA = "0x18163B3A0", Slot = "30")]
		protected override string GetWebWindowType()
		{
			return null;
		}

		// Token: 0x0601CD85 RID: 118149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD85")]
		[Address(RVA = "0x163B260", Offset = "0x1639E60", VA = "0x18163B260", Slot = "31")]
		protected override Dictionary<string, string> GetQuery()
		{
			return null;
		}

		// Token: 0x0601CD86 RID: 118150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD86")]
		[Address(RVA = "0x163B660", Offset = "0x163A260", VA = "0x18163B660", Slot = "36")]
		protected override void OnWebMessage(UIWebScheme msg)
		{
		}

		// Token: 0x0601CD87 RID: 118151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD87")]
		[Address(RVA = "0x163C280", Offset = "0x163AE80", VA = "0x18163C280")]
		private void _HandleJumpRecruitMessage(UIWebScheme msg)
		{
		}

		// Token: 0x0601CD88 RID: 118152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD88")]
		[Address(RVA = "0x163BF80", Offset = "0x163AB80", VA = "0x18163BF80")]
		private void _HandleJumpHomeMessage(UIWebScheme msg)
		{
		}

		// Token: 0x0601CD89 RID: 118153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD89")]
		[Address(RVA = "0x163CAF0", Offset = "0x163B6F0", VA = "0x18163CAF0")]
		private void _HandleJumpingShopMessage(UIWebScheme msg)
		{
		}

		// Token: 0x0601CD8A RID: 118154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD8A")]
		[Address(RVA = "0x163C8B0", Offset = "0x163B4B0", VA = "0x18163C8B0")]
		private void _HandleJumpingCrisisV2Message(UIWebScheme msg)
		{
		}

		// Token: 0x0601CD8B RID: 118155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD8B")]
		[Address(RVA = "0x163C460", Offset = "0x163B060", VA = "0x18163C460")]
		private void _HandleJumpToActivityStageMessage(UIWebScheme msg)
		{
		}

		// Token: 0x0601CD8C RID: 118156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD8C")]
		[Address(RVA = "0x163C730", Offset = "0x163B330", VA = "0x18163C730")]
		private void _HandleJumpingCharRepoMessage(UIWebScheme msg)
		{
		}

		// Token: 0x0601CD8D RID: 118157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD8D")]
		[Address(RVA = "0x163B420", Offset = "0x163A020", VA = "0x18163B420", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601CD8E RID: 118158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD8E")]
		[Address(RVA = "0x163B550", Offset = "0x163A150", VA = "0x18163B550", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601CD8F RID: 118159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD8F")]
		[Address(RVA = "0x163BD00", Offset = "0x163A900", VA = "0x18163BD00", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601CD90 RID: 118160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD90")]
		[Address(RVA = "0x163BE30", Offset = "0x163AA30", VA = "0x18163BE30", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601CD91 RID: 118161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD91")]
		[Address(RVA = "0x163CE10", Offset = "0x163BA10", VA = "0x18163CE10")]
		public HomeAnnounceWebState()
		{
		}

		// Token: 0x0601CD92 RID: 118162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD92")]
		[Address(RVA = "0x163BF40", Offset = "0x163AB40", VA = "0x18163BF40")]
		private Dictionary<string, string> <>xLuaBaseProxy_GetQuery()
		{
			return null;
		}

		// Token: 0x0601CD93 RID: 118163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD93")]
		[Address(RVA = "0x163BF50", Offset = "0x163AB50", VA = "0x18163BF50")]
		private void <>xLuaBaseProxy_OnWebMessage(UIWebScheme P0)
		{
		}

		// Token: 0x0601CD94 RID: 118164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD94")]
		[Address(RVA = "0x121A5A0", Offset = "0x12191A0", VA = "0x18121A5A0")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601CD95 RID: 118165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD95")]
		[Address(RVA = "0x121A5D0", Offset = "0x12191D0", VA = "0x18121A5D0")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x0601CD96 RID: 118166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD96")]
		[Address(RVA = "0x121A610", Offset = "0x1219210", VA = "0x18121A610")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601CD97 RID: 118167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD97")]
		[Address(RVA = "0x121A640", Offset = "0x1219240", VA = "0x18121A640")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x04025D8E RID: 155022
		[Token(Token = "0x4025D8E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private LuaUITransEffect _transEffect;

		// Token: 0x04025D8F RID: 155023
		[Token(Token = "0x4025D8F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025D90 RID: 155024
		[Token(Token = "0x4025D90")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetWebWindowType;

		// Token: 0x04025D91 RID: 155025
		[Token(Token = "0x4025D91")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetQuery;

		// Token: 0x04025D92 RID: 155026
		[Token(Token = "0x4025D92")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnWebMessage;

		// Token: 0x04025D93 RID: 155027
		[Token(Token = "0x4025D93")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__HandleJumpRecruitMessage;

		// Token: 0x04025D94 RID: 155028
		[Token(Token = "0x4025D94")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HandleJumpHomeMessage;

		// Token: 0x04025D95 RID: 155029
		[Token(Token = "0x4025D95")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleJumpingShopMessage;

		// Token: 0x04025D96 RID: 155030
		[Token(Token = "0x4025D96")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HandleJumpingCrisisV2Message;

		// Token: 0x04025D97 RID: 155031
		[Token(Token = "0x4025D97")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandleJumpToActivityStageMessage;

		// Token: 0x04025D98 RID: 155032
		[Token(Token = "0x4025D98")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HandleJumpingCharRepoMessage;

		// Token: 0x04025D99 RID: 155033
		[Token(Token = "0x4025D99")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04025D9A RID: 155034
		[Token(Token = "0x4025D9A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04025D9B RID: 155035
		[Token(Token = "0x4025D9B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04025D9C RID: 155036
		[Token(Token = "0x4025D9C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04025D9D RID: 155037
		[Token(Token = "0x4025D9D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
