using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public static class TMPro_EventManager
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x586BD60", Offset = "0x586A960", VA = "0x18586BD60")]
		public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x586BCD0", Offset = "0x586A8D0", VA = "0x18586BCD0")]
		public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x586BE50", Offset = "0x586AA50", VA = "0x18586BE50")]
		public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x586BEE0", Offset = "0x586AAE0", VA = "0x18586BEE0")]
		public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x586BC30", Offset = "0x586A830", VA = "0x18586BC30")]
		public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x586C080", Offset = "0x586AC80", VA = "0x18586C080")]
		public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x586BB20", Offset = "0x586A720", VA = "0x18586BB20")]
		public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x586C000", Offset = "0x586AC00", VA = "0x18586C000")]
		public static void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x586C100", Offset = "0x586AD00", VA = "0x18586C100")]
		public static void ON_TMP_SETTINGS_CHANGED()
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x586BDF0", Offset = "0x586A9F0", VA = "0x18586BDF0")]
		public static void ON_RESOURCES_LOADED()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x586BF70", Offset = "0x586AB70", VA = "0x18586BF70")]
		public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x586BBA0", Offset = "0x586A7A0", VA = "0x18586BBA0")]
		public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e)
		{
		}

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x8")]
		public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x10")]
		public static readonly FastAction<bool, UnityEngine.Object> FONT_PROPERTY_EVENT;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x18")]
		public static readonly FastAction<bool, UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x20")]
		public static readonly FastAction<bool, UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x28")]
		public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x30")]
		public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x38")]
		public static readonly FastAction<UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x40")]
		public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x48")]
		public static readonly FastAction RESOURCE_LOAD_EVENT;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x50")]
		public static readonly FastAction<bool, UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x58")]
		public static readonly FastAction<UnityEngine.Object> TEXT_CHANGED_EVENT;
	}
}
