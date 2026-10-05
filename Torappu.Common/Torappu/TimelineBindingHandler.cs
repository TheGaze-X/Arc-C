using System;
using System.Collections.Generic;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using XLua;

namespace Torappu
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public class TimelineBindingHandler : IHotfixable
	{
		// Token: 0x0600011C RID: 284 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x54F5DF0", Offset = "0x54F49F0", VA = "0x1854F5DF0")]
		public TimelineBindingHandler(PlayableDirector host)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000013")]
		public TimelineAsset timeline
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x54F5FC0", Offset = "0x54F4BC0", VA = "0x1854F5FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x54F4BE0", Offset = "0x54F37E0", VA = "0x1854F4BE0")]
		public void SetBinding(string name, UnityEngine.Object target)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x54F4EC0", Offset = "0x54F3AC0", VA = "0x1854F4EC0")]
		public void SetTimeline(TimelineAsset timeline)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x54F4AD0", Offset = "0x54F36D0", VA = "0x1854F4AD0")]
		public void Clear(bool bClearBindTargets)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x54F58D0", Offset = "0x54F44D0", VA = "0x1854F58D0")]
		private void _RemoveFromTrackMap(string name)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x54F54F0", Offset = "0x54F40F0", VA = "0x1854F54F0")]
		private void _AddToTrackMap(string name, UnityEngine.Object target)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x54F5680", Offset = "0x54F4280", VA = "0x1854F5680")]
		private void _ClearTrackMap()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x54F5A40", Offset = "0x54F4640", VA = "0x1854F5A40")]
		private void _ShrinkBindableMap()
		{
		}

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x10")]
		private PlayableDirector m_host;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x18")]
		private LocalGenericPool<TimelineBindingHandler.Binding> m_bindingPool;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, UnityEngine.Object> m_bindableMaps;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x28")]
		private TimelineAsset m_timeline;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, TimelineBindingHandler.Binding> m_trackMap;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate0 _c__Hotfix0_ctor;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate4 __Hotfix0_get_timeline;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate5 __Hotfix0_SetBinding;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate0 __Hotfix0_SetTimeline;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate6 __Hotfix0_Clear;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate0 __Hotfix0__RemoveFromTrackMap;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate5 __Hotfix0__AddToTrackMap;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ClearTrackMap;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ShrinkBindableMap;

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		private class Binding
		{
			// Token: 0x06000125 RID: 293 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x54DAE90", Offset = "0x54D9A90", VA = "0x1854DAE90")]
			public static void Clean(TimelineBindingHandler.Binding inst)
			{
			}

			// Token: 0x06000126 RID: 294 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Binding()
			{
			}

			// Token: 0x04000146 RID: 326
			[Token(Token = "0x4000146")]
			[FieldOffset(Offset = "0x10")]
			public TrackAsset track;

			// Token: 0x04000147 RID: 327
			[Token(Token = "0x4000147")]
			[FieldOffset(Offset = "0x18")]
			public UnityEngine.Object target;
		}
	}
}
