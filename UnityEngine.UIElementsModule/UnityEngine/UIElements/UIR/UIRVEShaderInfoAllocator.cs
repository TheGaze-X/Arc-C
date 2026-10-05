using System;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002C3 RID: 707
	[Token(Token = "0x20002C3")]
	internal struct UIRVEShaderInfoAllocator
	{
		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x0000A050 File Offset: 0x00008250
		[Token(Token = "0x170004AF")]
		private static int pageWidth
		{
			[Token(Token = "0x6001326")]
			[Address(RVA = "0x5A5F440", Offset = "0x5A5E040", VA = "0x185A5F440")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x0000A068 File Offset: 0x00008268
		[Token(Token = "0x170004B0")]
		private static int pageHeight
		{
			[Token(Token = "0x6001327")]
			[Address(RVA = "0x5A5F430", Offset = "0x5A5E030", VA = "0x185A5F430")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0000A080 File Offset: 0x00008280
		[Token(Token = "0x6001328")]
		[Address(RVA = "0x5A5C9F0", Offset = "0x5A5B5F0", VA = "0x185A5C9F0")]
		private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc)
		{
			return default(Vector2Int);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0000A098 File Offset: 0x00008298
		[Token(Token = "0x6001329")]
		[Address(RVA = "0x5A5C9A0", Offset = "0x5A5B5A0", VA = "0x185A5C9A0")]
		private static int AllocToConstantBufferIndex(BMPAlloc alloc)
		{
			return 0;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[Token(Token = "0x600132A")]
		[Address(RVA = "0x5A5CBD0", Offset = "0x5A5B7D0", VA = "0x185A5CBD0")]
		private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect)
		{
			return default(bool);
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x0000A0C8 File Offset: 0x000082C8
		[Token(Token = "0x170004B1")]
		public NativeSlice<Transform3x4> transformConstants
		{
			[Token(Token = "0x600132B")]
			[Address(RVA = "0x5A5F450", Offset = "0x5A5E050", VA = "0x185A5F450")]
			get
			{
				return default(NativeSlice<Transform3x4>);
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x0000A0E0 File Offset: 0x000082E0
		[Token(Token = "0x170004B2")]
		public NativeSlice<Vector4> clipRectConstants
		{
			[Token(Token = "0x600132C")]
			[Address(RVA = "0x5A5F3C0", Offset = "0x5A5DFC0", VA = "0x185A5F3C0")]
			get
			{
				return default(NativeSlice<Vector4>);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170004B3")]
		public Texture atlas
		{
			[Token(Token = "0x600132D")]
			[Address(RVA = "0x5A5F310", Offset = "0x5A5DF10", VA = "0x185A5F310")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132E")]
		[Address(RVA = "0x5A5CF40", Offset = "0x5A5BB40", VA = "0x185A5CF40")]
		public void Construct()
		{
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132F")]
		[Address(RVA = "0x5A5D990", Offset = "0x5A5C590", VA = "0x185A5D990")]
		private void ReallyCreateStorage()
		{
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001330")]
		[Address(RVA = "0x5A5D460", Offset = "0x5A5C060", VA = "0x185A5D460")]
		public void Dispose()
		{
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001331")]
		[Address(RVA = "0x5A5D830", Offset = "0x5A5C430", VA = "0x185A5D830")]
		public void IssuePendingStorageChanges()
		{
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[Token(Token = "0x6001332")]
		[Address(RVA = "0x5A5CA80", Offset = "0x5A5B680", VA = "0x185A5CA80")]
		public BMPAlloc AllocTransform()
		{
			return default(BMPAlloc);
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x0000A110 File Offset: 0x00008310
		[Token(Token = "0x6001333")]
		[Address(RVA = "0x5A5C700", Offset = "0x5A5B300", VA = "0x185A5C700")]
		public BMPAlloc AllocClipRect()
		{
			return default(BMPAlloc);
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x6001334")]
		[Address(RVA = "0x5A5C8C0", Offset = "0x5A5B4C0", VA = "0x185A5C8C0")]
		public BMPAlloc AllocOpacity()
		{
			return default(BMPAlloc);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0000A140 File Offset: 0x00008340
		[Token(Token = "0x6001335")]
		[Address(RVA = "0x5A5C850", Offset = "0x5A5B450", VA = "0x185A5C850")]
		public BMPAlloc AllocColor()
		{
			return default(BMPAlloc);
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0000A158 File Offset: 0x00008358
		[Token(Token = "0x6001336")]
		[Address(RVA = "0x5A5C930", Offset = "0x5A5B530", VA = "0x185A5C930")]
		public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings)
		{
			return default(BMPAlloc);
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001337")]
		[Address(RVA = "0x5A5EA40", Offset = "0x5A5D640", VA = "0x185A5EA40")]
		public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform)
		{
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001338")]
		[Address(RVA = "0x5A5E100", Offset = "0x5A5CD00", VA = "0x185A5E100")]
		public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect)
		{
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001339")]
		[Address(RVA = "0x5A5E480", Offset = "0x5A5D080", VA = "0x185A5E480")]
		public void SetOpacityValue(BMPAlloc alloc, float opacity)
		{
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133A")]
		[Address(RVA = "0x5A5E2C0", Offset = "0x5A5CEC0", VA = "0x185A5E2C0")]
		public void SetColorValue(BMPAlloc alloc, Color color, bool isEditorContext)
		{
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133B")]
		[Address(RVA = "0x5A5E5C0", Offset = "0x5A5D1C0", VA = "0x185A5E5C0")]
		public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext)
		{
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133C")]
		[Address(RVA = "0x5A5D790", Offset = "0x5A5C390", VA = "0x185A5D790")]
		public void FreeTransform(BMPAlloc alloc)
		{
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133D")]
		[Address(RVA = "0x5A5D510", Offset = "0x5A5C110", VA = "0x185A5D510")]
		public void FreeClipRect(BMPAlloc alloc)
		{
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x5A5D650", Offset = "0x5A5C250", VA = "0x185A5D650")]
		public void FreeOpacity(BMPAlloc alloc)
		{
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133F")]
		[Address(RVA = "0x5A5D5B0", Offset = "0x5A5C1B0", VA = "0x185A5D5B0")]
		public void FreeColor(BMPAlloc alloc)
		{
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001340")]
		[Address(RVA = "0x5A5D6F0", Offset = "0x5A5C2F0", VA = "0x185A5D6F0")]
		public void FreeTextCoreSettings(BMPAlloc alloc)
		{
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0000A170 File Offset: 0x00008370
		[Token(Token = "0x6001341")]
		[Address(RVA = "0x5A5EEE0", Offset = "0x5A5DAE0", VA = "0x185A5EEE0")]
		public Color32 TransformAllocToVertexData(BMPAlloc alloc)
		{
			return default(Color32);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0000A188 File Offset: 0x00008388
		[Token(Token = "0x6001342")]
		[Address(RVA = "0x5A5CCF0", Offset = "0x5A5B8F0", VA = "0x185A5CCF0")]
		public Color32 ClipRectAllocToVertexData(BMPAlloc alloc)
		{
			return default(Color32);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0000A1A0 File Offset: 0x000083A0
		[Token(Token = "0x6001343")]
		[Address(RVA = "0x5A5D870", Offset = "0x5A5C470", VA = "0x185A5D870")]
		public Color32 OpacityAllocToVertexData(BMPAlloc alloc)
		{
			return default(Color32);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0000A1B8 File Offset: 0x000083B8
		[Token(Token = "0x6001344")]
		[Address(RVA = "0x5A5CE20", Offset = "0x5A5BA20", VA = "0x185A5CE20")]
		public Color32 ColorAllocToVertexData(BMPAlloc alloc)
		{
			return default(Color32);
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0000A1D0 File Offset: 0x000083D0
		[Token(Token = "0x6001345")]
		[Address(RVA = "0x5A5EDC0", Offset = "0x5A5D9C0", VA = "0x185A5EDC0")]
		public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc)
		{
			return default(Color32);
		}

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x0")]
		private BaseShaderInfoStorage m_Storage;

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x8")]
		private BitmapAllocator32 m_TransformAllocator;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x28")]
		private BitmapAllocator32 m_ClipRectAllocator;

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4000AB8")]
		[FieldOffset(Offset = "0x48")]
		private BitmapAllocator32 m_OpacityAllocator;

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4000AB9")]
		[FieldOffset(Offset = "0x68")]
		private BitmapAllocator32 m_ColorAllocator;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4000ABA")]
		[FieldOffset(Offset = "0x88")]
		private BitmapAllocator32 m_TextSettingsAllocator;

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_StorageReallyCreated;

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4000ABC")]
		[FieldOffset(Offset = "0xA9")]
		private bool m_VertexTexturingEnabled;

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0xB0")]
		private NativeArray<Transform3x4> m_Transforms;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		[FieldOffset(Offset = "0xC0")]
		private NativeArray<Vector4> m_ClipRects;

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Vector2Int identityTransformTexel;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4000AC0")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly Vector2Int infiniteClipRectTexel;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly Vector2Int fullOpacityTexel;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly Vector2Int clearColorTexel;

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4000AC3")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly Vector2Int defaultTextCoreSettingsTexel;

		// Token: 0x04000AC4 RID: 2756
		[Token(Token = "0x4000AC4")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly Matrix4x4 identityTransformValue;

		// Token: 0x04000AC5 RID: 2757
		[Token(Token = "0x4000AC5")]
		[FieldOffset(Offset = "0x68")]
		internal static readonly Vector4 identityTransformRow0Value;

		// Token: 0x04000AC6 RID: 2758
		[Token(Token = "0x4000AC6")]
		[FieldOffset(Offset = "0x78")]
		internal static readonly Vector4 identityTransformRow1Value;

		// Token: 0x04000AC7 RID: 2759
		[Token(Token = "0x4000AC7")]
		[FieldOffset(Offset = "0x88")]
		internal static readonly Vector4 identityTransformRow2Value;

		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4000AC8")]
		[FieldOffset(Offset = "0x98")]
		internal static readonly Vector4 infiniteClipRectValue;

		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		[FieldOffset(Offset = "0xA8")]
		internal static readonly Vector4 fullOpacityValue;

		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		[FieldOffset(Offset = "0xB8")]
		internal static readonly Vector4 clearColorValue;

		// Token: 0x04000ACB RID: 2763
		[Token(Token = "0x4000ACB")]
		[FieldOffset(Offset = "0xC8")]
		internal static readonly TextCoreSettings defaultTextCoreSettingsValue;

		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4000ACC")]
		[FieldOffset(Offset = "0x108")]
		public static readonly BMPAlloc identityTransform;

		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4000ACD")]
		[FieldOffset(Offset = "0x110")]
		public static readonly BMPAlloc infiniteClipRect;

		// Token: 0x04000ACE RID: 2766
		[Token(Token = "0x4000ACE")]
		[FieldOffset(Offset = "0x118")]
		public static readonly BMPAlloc fullOpacity;

		// Token: 0x04000ACF RID: 2767
		[Token(Token = "0x4000ACF")]
		[FieldOffset(Offset = "0x120")]
		public static readonly BMPAlloc clearColor;

		// Token: 0x04000AD0 RID: 2768
		[Token(Token = "0x4000AD0")]
		[FieldOffset(Offset = "0x128")]
		public static readonly BMPAlloc defaultTextCoreSettings;
	}
}
