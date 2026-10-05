using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EC2 RID: 7874
	[Token(Token = "0x2001EC2")]
	public class BackgroundPanel : AVGImagePanel, IContainsResRefs
	{
		// Token: 0x0600C31E RID: 49950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C31E")]
		[Address(RVA = "0x3407330", Offset = "0x3405F30", VA = "0x183407330", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C31F RID: 49951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C31F")]
		[Address(RVA = "0x34072A0", Offset = "0x3405EA0", VA = "0x1834072A0", Slot = "19")]
		public override AbstractResRefCollecter DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600C320 RID: 49952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C320")]
		[Address(RVA = "0x3407660", Offset = "0x3406260", VA = "0x183407660", Slot = "20")]
		protected override Sprite _LoadSprite(string key)
		{
			return null;
		}

		// Token: 0x0600C321 RID: 49953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C321")]
		[Address(RVA = "0x3407520", Offset = "0x3406120", VA = "0x183407520", Slot = "16")]
		protected override string PostDisplayKey1()
		{
			return null;
		}

		// Token: 0x0600C322 RID: 49954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C322")]
		[Address(RVA = "0x3407590", Offset = "0x3406190", VA = "0x183407590", Slot = "17")]
		protected override string PostDisplayKey2()
		{
			return null;
		}

		// Token: 0x0600C323 RID: 49955 RVA: 0x000479E8 File Offset: 0x00045BE8
		[Token(Token = "0x600C323")]
		[Address(RVA = "0x34074C0", Offset = "0x34060C0", VA = "0x1834074C0", Slot = "18")]
		protected override PostDisplayType GetPostDisplayType()
		{
			return PostDisplayType.NONE;
		}

		// Token: 0x0600C324 RID: 49956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C324")]
		[Address(RVA = "0x3407710", Offset = "0x3406310", VA = "0x183407710")]
		public BackgroundPanel()
		{
		}

		// Token: 0x0600C325 RID: 49957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C325")]
		[Address(RVA = "0x3407610", Offset = "0x3406210", VA = "0x183407610")]
		private Dictionary<string, ExecutorComponent.Executor> <>xLuaBaseProxy_GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C326 RID: 49958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C326")]
		[Address(RVA = "0x3407600", Offset = "0x3406200", VA = "0x183407600")]
		private AbstractResRefCollecter <>xLuaBaseProxy_DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600C327 RID: 49959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C327")]
		[Address(RVA = "0x3407650", Offset = "0x3406250", VA = "0x183407650")]
		private Sprite <>xLuaBaseProxy__LoadSprite(string P0)
		{
			return null;
		}

		// Token: 0x0600C328 RID: 49960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C328")]
		[Address(RVA = "0x3407630", Offset = "0x3406230", VA = "0x183407630")]
		private string <>xLuaBaseProxy_PostDisplayKey1()
		{
			return null;
		}

		// Token: 0x0600C329 RID: 49961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C329")]
		[Address(RVA = "0x3407640", Offset = "0x3406240", VA = "0x183407640")]
		private string <>xLuaBaseProxy_PostDisplayKey2()
		{
			return null;
		}

		// Token: 0x0600C32A RID: 49962 RVA: 0x00047A00 File Offset: 0x00045C00
		[Token(Token = "0x600C32A")]
		[Address(RVA = "0x3407620", Offset = "0x3406220", VA = "0x183407620")]
		private PostDisplayType <>xLuaBaseProxy_GetPostDisplayType()
		{
			return PostDisplayType.NONE;
		}

		// Token: 0x0400C535 RID: 50485
		[Token(Token = "0x400C535")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C536 RID: 50486
		[Token(Token = "0x400C536")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DontInvoke_PlzImplInternalResRefCollector;

		// Token: 0x0400C537 RID: 50487
		[Token(Token = "0x400C537")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadSprite;

		// Token: 0x0400C538 RID: 50488
		[Token(Token = "0x400C538")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PostDisplayKey1;

		// Token: 0x0400C539 RID: 50489
		[Token(Token = "0x400C539")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PostDisplayKey2;

		// Token: 0x0400C53A RID: 50490
		[Token(Token = "0x400C53A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPostDisplayType;

		// Token: 0x0400C53B RID: 50491
		[Token(Token = "0x400C53B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001EC3 RID: 7875
		[Token(Token = "0x2001EC3")]
		private class InternalResRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C32B RID: 49963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C32B")]
			[Address(RVA = "0x34133E0", Offset = "0x3411FE0", VA = "0x1834133E0", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x0600C32C RID: 49964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C32C")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public InternalResRefCollector()
			{
			}
		}
	}
}
