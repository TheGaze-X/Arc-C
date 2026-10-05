using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002382 RID: 9090
	[Token(Token = "0x2002382")]
	public abstract class MapThemeController : IHotfixable
	{
		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x0600E6AA RID: 59050 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E6AB RID: 59051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001CF9")]
		private protected MapThemeData data
		{
			[Token(Token = "0x600E6AA")]
			[Address(RVA = "0x5C3C40", Offset = "0x5C2840", VA = "0x1805C3C40")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600E6AB")]
			[Address(RVA = "0x5C3D00", Offset = "0x5C2900", VA = "0x1805C3D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x0600E6AC RID: 59052 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E6AD RID: 59053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001CFA")]
		private protected Map map
		{
			[Token(Token = "0x600E6AC")]
			[Address(RVA = "0x5C3CA0", Offset = "0x5C28A0", VA = "0x1805C3CA0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600E6AD")]
			[Address(RVA = "0x5C3D80", Offset = "0x5C2980", VA = "0x1805C3D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600E6AE RID: 59054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6AE")]
		[Address(RVA = "0x5C3B20", Offset = "0x5C2720", VA = "0x1805C3B20")]
		public MapThemeController(MapThemeData data_, Map map_)
		{
		}

		// Token: 0x0600E6AF RID: 59055 RVA: 0x000540F0 File Offset: 0x000522F0
		[Token(Token = "0x600E6AF")]
		[Address(RVA = "0x5C37F0", Offset = "0x5C23F0", VA = "0x1805C37F0")]
		public Color GetThemeUnitColor()
		{
			return default(Color);
		}

		// Token: 0x0600E6B0 RID: 59056 RVA: 0x00054108 File Offset: 0x00052308
		[Token(Token = "0x600E6B0")]
		[Address(RVA = "0x5C34B0", Offset = "0x5C20B0", VA = "0x1805C34B0")]
		public Color GetThemeBuildableColor()
		{
			return default(Color);
		}

		// Token: 0x0600E6B1 RID: 59057 RVA: 0x00054120 File Offset: 0x00052320
		[Token(Token = "0x600E6B1")]
		[Address(RVA = "0x5C3980", Offset = "0x5C2580", VA = "0x1805C3980")]
		public Color GetTrapTintColor()
		{
			return default(Color);
		}

		// Token: 0x0600E6B2 RID: 59058 RVA: 0x00054138 File Offset: 0x00052338
		[Token(Token = "0x600E6B2")]
		[Address(RVA = "0x5C3650", Offset = "0x5C2250", VA = "0x1805C3650")]
		public Color GetThemeEmissionColor()
		{
			return default(Color);
		}

		// Token: 0x0600E6B3 RID: 59059
		[Token(Token = "0x600E6B3")]
		public abstract void OnInit();

		// Token: 0x0400FE0C RID: 65036
		[Token(Token = "0x400FE0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x0400FE0D RID: 65037
		[Token(Token = "0x400FE0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_data;

		// Token: 0x0400FE0E RID: 65038
		[Token(Token = "0x400FE0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_map;

		// Token: 0x0400FE0F RID: 65039
		[Token(Token = "0x400FE0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_map;

		// Token: 0x0400FE10 RID: 65040
		[Token(Token = "0x400FE10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400FE11 RID: 65041
		[Token(Token = "0x400FE11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetThemeUnitColor;

		// Token: 0x0400FE12 RID: 65042
		[Token(Token = "0x400FE12")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetThemeBuildableColor;

		// Token: 0x0400FE13 RID: 65043
		[Token(Token = "0x400FE13")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetTrapTintColor;

		// Token: 0x0400FE14 RID: 65044
		[Token(Token = "0x400FE14")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetThemeEmissionColor;
	}
}
