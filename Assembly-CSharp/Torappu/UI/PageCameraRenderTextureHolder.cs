using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200374C RID: 14156
	[Token(Token = "0x200374C")]
	[RequireComponent(typeof(Camera))]
	public class PageCameraRenderTextureHolder : PageComponent, IPageCameraMarker, IPageComponentMarker, IHotfixable
	{
		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x060167DE RID: 92126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035E0")]
		public RenderTexture activeRenderTexture
		{
			[Token(Token = "0x60167DE")]
			[Address(RVA = "0xEDDFA0", Offset = "0xEDCBA0", VA = "0x180EDDFA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060167DF RID: 92127 RVA: 0x00091620 File Offset: 0x0008F820
		[Token(Token = "0x60167DF")]
		[Address(RVA = "0xEDD910", Offset = "0xEDC510", VA = "0x180EDD910", Slot = "12")]
		public bool IsCollectable()
		{
			return default(bool);
		}

		// Token: 0x060167E0 RID: 92128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167E0")]
		[Address(RVA = "0xEDD970", Offset = "0xEDC570", VA = "0x180EDD970", Slot = "4")]
		protected override void OnAwake()
		{
		}

		// Token: 0x060167E1 RID: 92129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167E1")]
		[Address(RVA = "0xEDDA00", Offset = "0xEDC600", VA = "0x180EDDA00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x060167E2 RID: 92130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167E2")]
		[Address(RVA = "0xEDDBB0", Offset = "0xEDC7B0", VA = "0x180EDDBB0", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060167E3 RID: 92131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167E3")]
		[Address(RVA = "0xEDDDC0", Offset = "0xEDC9C0", VA = "0x180EDDDC0")]
		private void _RequestRenderTexture()
		{
		}

		// Token: 0x060167E4 RID: 92132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167E4")]
		[Address(RVA = "0xEDDCC0", Offset = "0xEDC8C0", VA = "0x180EDDCC0")]
		private void _ReleaseRenderTexture()
		{
		}

		// Token: 0x060167E5 RID: 92133 RVA: 0x00091638 File Offset: 0x0008F838
		[Token(Token = "0x60167E5")]
		[Address(RVA = "0xEDDC50", Offset = "0xEDC850", VA = "0x180EDDC50")]
		private RenderTextureFormat _GetSupportedTextureFormat()
		{
			return RenderTextureFormat.ARGB32;
		}

		// Token: 0x060167E6 RID: 92134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167E6")]
		[Address(RVA = "0xEDDF30", Offset = "0xEDCB30", VA = "0x180EDDF30")]
		public PageCameraRenderTextureHolder()
		{
		}

		// Token: 0x060167E7 RID: 92135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167E7")]
		[Address(RVA = "0xEDDC20", Offset = "0xEDC820", VA = "0x180EDDC20")]
		private void <>xLuaBaseProxy_OnAwake()
		{
		}

		// Token: 0x060167E8 RID: 92136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167E8")]
		[Address(RVA = "0xEDDC30", Offset = "0xEDC830", VA = "0x180EDDC30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x060167E9 RID: 92137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167E9")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0401B17F RID: 110975
		[Token(Token = "0x401B17F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GenRTFormat _genRTFormat;

		// Token: 0x0401B180 RID: 110976
		[Token(Token = "0x401B180")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FilterMode _filterMode;

		// Token: 0x0401B181 RID: 110977
		[Token(Token = "0x401B181")]
		[FieldOffset(Offset = "0x38")]
		private Camera m_rtCamera;

		// Token: 0x0401B182 RID: 110978
		[Token(Token = "0x401B182")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_activeRT;

		// Token: 0x0401B183 RID: 110979
		[Token(Token = "0x401B183")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activeRenderTexture;

		// Token: 0x0401B184 RID: 110980
		[Token(Token = "0x401B184")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsCollectable;

		// Token: 0x0401B185 RID: 110981
		[Token(Token = "0x401B185")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAwake;

		// Token: 0x0401B186 RID: 110982
		[Token(Token = "0x401B186")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401B187 RID: 110983
		[Token(Token = "0x401B187")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B188 RID: 110984
		[Token(Token = "0x401B188")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RequestRenderTexture;

		// Token: 0x0401B189 RID: 110985
		[Token(Token = "0x401B189")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ReleaseRenderTexture;

		// Token: 0x0401B18A RID: 110986
		[Token(Token = "0x401B18A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetSupportedTextureFormat;

		// Token: 0x0401B18B RID: 110987
		[Token(Token = "0x401B18B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
