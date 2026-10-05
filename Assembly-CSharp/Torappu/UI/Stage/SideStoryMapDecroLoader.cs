using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200680B RID: 26635
	[Token(Token = "0x200680B")]
	public class SideStoryMapDecroLoader : PageSingleComponent, IHotfixable
	{
		// Token: 0x0602629A RID: 156314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602629A")]
		[Address(RVA = "0x2135510", Offset = "0x2134110", VA = "0x182135510")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602629B RID: 156315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602629B")]
		[Address(RVA = "0x2134C10", Offset = "0x2133810", VA = "0x182134C10")]
		public void RenderSelectZone(ZoneViewModel zoneViewModel)
		{
		}

		// Token: 0x0602629C RID: 156316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602629C")]
		[Address(RVA = "0x2135570", Offset = "0x2134170", VA = "0x182135570")]
		private void _RenderMain(ZoneViewModel zoneViewModel)
		{
		}

		// Token: 0x0602629D RID: 156317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602629D")]
		[Address(RVA = "0x2135C80", Offset = "0x2134880", VA = "0x182135C80")]
		private void _RenderRetro(ZoneViewModel zoneViewModel)
		{
		}

		// Token: 0x0602629E RID: 156318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602629E")]
		[Address(RVA = "0x21352C0", Offset = "0x2133EC0", VA = "0x1821352C0")]
		private StageSideStoryMapDecroViewBase _GetView(string id)
		{
			return null;
		}

		// Token: 0x0602629F RID: 156319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602629F")]
		[Address(RVA = "0x2135210", Offset = "0x2133E10", VA = "0x182135210")]
		private MainMapDecroView _GetMainView(string id)
		{
			return null;
		}

		// Token: 0x060262A0 RID: 156320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262A0")]
		[Address(RVA = "0x2135900", Offset = "0x2134500", VA = "0x182135900")]
		private void _RenderRetroDecroView(string retroId, ZoneViewModel curZone, List<ZoneViewModel> curRetroZones)
		{
		}

		// Token: 0x060262A1 RID: 156321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262A1")]
		[Address(RVA = "0x2136000", Offset = "0x2134C00", VA = "0x182136000")]
		private void _RenderTrail(string retroId)
		{
		}

		// Token: 0x060262A2 RID: 156322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60262A2")]
		[Address(RVA = "0x2134D80", Offset = "0x2133980", VA = "0x182134D80")]
		private static SideStoryMapDecroLoader _CheckInst(UIPageFinder.Interface pageInterface)
		{
			return null;
		}

		// Token: 0x060262A3 RID: 156323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262A3")]
		[Address(RVA = "0x2134900", Offset = "0x2133500", VA = "0x182134900")]
		public static void RegisterSideStoryZones(UIPageFinder.Interface page, ListDict<ZoneViewType, ZoneGroupViewModel> zones)
		{
		}

		// Token: 0x060262A4 RID: 156324 RVA: 0x000CA368 File Offset: 0x000C8568
		[Token(Token = "0x60262A4")]
		[Address(RVA = "0x2134CF0", Offset = "0x21338F0", VA = "0x182134CF0")]
		private static bool _CheckIfRetroZone(ZoneViewModel zoneModel)
		{
			return default(bool);
		}

		// Token: 0x060262A5 RID: 156325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262A5")]
		[Address(RVA = "0x2135370", Offset = "0x2133F70", VA = "0x182135370")]
		private void _GetZonesForRetro(string retroId, List<ZoneViewModel> outputList)
		{
		}

		// Token: 0x060262A6 RID: 156326 RVA: 0x000CA380 File Offset: 0x000C8580
		[Token(Token = "0x60262A6")]
		[Address(RVA = "0x2134F70", Offset = "0x2133B70", VA = "0x182134F70")]
		private bool _FocusToZone(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x060262A7 RID: 156327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60262A7")]
		[Address(RVA = "0x21350B0", Offset = "0x2133CB0", VA = "0x1821350B0")]
		private string _GetCurrentSelectedZone()
		{
			return null;
		}

		// Token: 0x060262A8 RID: 156328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262A8")]
		[Address(RVA = "0x2134E40", Offset = "0x2133A40", VA = "0x182134E40")]
		private void _ExitCurrentRetro()
		{
		}

		// Token: 0x060262A9 RID: 156329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262A9")]
		[Address(RVA = "0x21361C0", Offset = "0x2134DC0", VA = "0x1821361C0")]
		public SideStoryMapDecroLoader()
		{
		}

		// Token: 0x04035C1F RID: 220191
		[Token(Token = "0x4035C1F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SideStoryMapDecroTrailInfo _trailInfo;

		// Token: 0x04035C20 RID: 220192
		[Token(Token = "0x4035C20")]
		[FieldOffset(Offset = "0x28")]
		private SideStoryMapDecroTrailInfo m_trailInfo;

		// Token: 0x04035C21 RID: 220193
		[Token(Token = "0x4035C21")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04035C22 RID: 220194
		[Token(Token = "0x4035C22")]
		[FieldOffset(Offset = "0x38")]
		private StageSideStoryMapDecroViewBase m_decroView;

		// Token: 0x04035C23 RID: 220195
		[Token(Token = "0x4035C23")]
		[FieldOffset(Offset = "0x40")]
		private MainMapDecroView m_mainDecroView;

		// Token: 0x04035C24 RID: 220196
		[Token(Token = "0x4035C24")]
		[FieldOffset(Offset = "0x48")]
		private string m_decroRetroId;

		// Token: 0x04035C25 RID: 220197
		[Token(Token = "0x4035C25")]
		[FieldOffset(Offset = "0x50")]
		private string m_mainZoneId;

		// Token: 0x04035C26 RID: 220198
		[Token(Token = "0x4035C26")]
		[FieldOffset(Offset = "0x58")]
		private List<ZoneViewModel> m_sideStoryZones;

		// Token: 0x04035C27 RID: 220199
		[Token(Token = "0x4035C27")]
		[FieldOffset(Offset = "0x60")]
		private List<ZoneViewModel> m_curRetroZones;

		// Token: 0x04035C28 RID: 220200
		[Token(Token = "0x4035C28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035C29 RID: 220201
		[Token(Token = "0x4035C29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderSelectZone;

		// Token: 0x04035C2A RID: 220202
		[Token(Token = "0x4035C2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderMain;

		// Token: 0x04035C2B RID: 220203
		[Token(Token = "0x4035C2B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderRetro;

		// Token: 0x04035C2C RID: 220204
		[Token(Token = "0x4035C2C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetView;

		// Token: 0x04035C2D RID: 220205
		[Token(Token = "0x4035C2D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetMainView;

		// Token: 0x04035C2E RID: 220206
		[Token(Token = "0x4035C2E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderRetroDecroView;

		// Token: 0x04035C2F RID: 220207
		[Token(Token = "0x4035C2F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderTrail;

		// Token: 0x04035C30 RID: 220208
		[Token(Token = "0x4035C30")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckInst;

		// Token: 0x04035C31 RID: 220209
		[Token(Token = "0x4035C31")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RegisterSideStoryZones;

		// Token: 0x04035C32 RID: 220210
		[Token(Token = "0x4035C32")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckIfRetroZone;

		// Token: 0x04035C33 RID: 220211
		[Token(Token = "0x4035C33")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetZonesForRetro;

		// Token: 0x04035C34 RID: 220212
		[Token(Token = "0x4035C34")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__FocusToZone;

		// Token: 0x04035C35 RID: 220213
		[Token(Token = "0x4035C35")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetCurrentSelectedZone;

		// Token: 0x04035C36 RID: 220214
		[Token(Token = "0x4035C36")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ExitCurrentRetro;

		// Token: 0x04035C37 RID: 220215
		[Token(Token = "0x4035C37")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
