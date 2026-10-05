using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(CanvasRenderer))]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public abstract class Graphic : UIBehaviour, ICanvasElement
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public static Material defaultGraphicMaterial
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x5A18A20", Offset = "0x5A17620", VA = "0x185A18A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000023E8 File Offset: 0x000005E8
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000036")]
		public virtual Color color
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xF10AF0", Offset = "0xF0F6F0", VA = "0x180F10AF0", Slot = "22")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x5A191A0", Offset = "0x5A17DA0", VA = "0x185A191A0", Slot = "23")]
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002400 File Offset: 0x00000600
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000037")]
		public virtual bool raycastTarget
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xF02F50", Offset = "0xF01B50", VA = "0x180F02F50", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x5A19310", Offset = "0x5A17F10", VA = "0x185A19310", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002418 File Offset: 0x00000618
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000038")]
		public Vector4 raycastPadding
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2569140", Offset = "0x2567D40", VA = "0x182569140")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x370A9A0", Offset = "0x37095A0", VA = "0x18370A9A0")]
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002430 File Offset: 0x00000630
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000039")]
		public virtual bool enableRuntimeAtlas
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x9069B0", Offset = "0x9055B0", VA = "0x1809069B0", Slot = "26")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x5A19200", Offset = "0x5A17E00", VA = "0x185A19200", Slot = "27")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003A")]
		public Texture runtimeAtlasTexture
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x5A193F0", Offset = "0x5A17FF0", VA = "0x185A193F0")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00002448 File Offset: 0x00000648
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003B")]
		protected bool useLegacyMeshGeneration
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x32F71F0", Offset = "0x32F5DF0", VA = "0x1832F71F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x32F7210", Offset = "0x32F5E10", VA = "0x1832F7210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x5A18820", Offset = "0x5A17420", VA = "0x185A18820")]
		protected Graphic()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x5A17FB0", Offset = "0x5A16BB0", VA = "0x185A17FB0", Slot = "28")]
		public virtual void SetAllDirty()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x5A18050", Offset = "0x5A16C50", VA = "0x185A18050", Slot = "29")]
		public virtual void SetLayoutDirty()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x5A18300", Offset = "0x5A16F00", VA = "0x185A18300", Slot = "30")]
		public virtual void SetVerticesDirty()
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x5A18140", Offset = "0x5A16D40", VA = "0x185A18140", Slot = "31")]
		public virtual void SetMaterialDirty()
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x5A18220", Offset = "0x5A16E20", VA = "0x185A18220")]
		public void SetRaycastDirty()
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x5A17600", Offset = "0x5A16200", VA = "0x185A17600", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x5A16AB0", Offset = "0x5A156B0", VA = "0x185A16AB0", Slot = "11")]
		protected override void OnBeforeTransformParentChanged()
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x5A17730", Offset = "0x5A16330", VA = "0x185A17730", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x1700003C")]
		public int depth
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x5A18C40", Offset = "0x5A17840", VA = "0x185A18C40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x5A18FC0", Offset = "0x5A17BC0", VA = "0x185A18FC0", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public Canvas canvas
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x5A189B0", Offset = "0x5A175B0", VA = "0x185A189B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x5A159B0", Offset = "0x5A145B0", VA = "0x185A159B0")]
		private void CacheCanvas()
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003F")]
		public CanvasRenderer canvasRenderer
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x5A18900", Offset = "0x5A17500", VA = "0x185A18900")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		public virtual Material defaultMaterial
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x5A18B20", Offset = "0x5A17720", VA = "0x185A18B20", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000041")]
		public virtual Material material
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x5A18F20", Offset = "0x5A17B20", VA = "0x185A18F20", Slot = "34")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x5A19260", Offset = "0x5A17E60", VA = "0x185A19260", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public virtual Material materialForRendering
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x5A18CC0", Offset = "0x5A178C0", VA = "0x185A18CC0", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public virtual Texture mainTexture
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x5A18C70", Offset = "0x5A17870", VA = "0x185A18C70", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x5A17140", Offset = "0x5A15D40", VA = "0x185A17140", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x5A16F80", Offset = "0x5A15B80", VA = "0x185A16F80", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x5A16E20", Offset = "0x5A15A20", VA = "0x185A16E20", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x5A16BD0", Offset = "0x5A157D0", VA = "0x185A16BD0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x5A16D50", Offset = "0x5A15950", VA = "0x185A16D50", Slot = "38")]
		public virtual void OnCullingChanged()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x5A17D00", Offset = "0x5A16900", VA = "0x185A17D00", Slot = "39")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "40")]
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "41")]
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x5A185E0", Offset = "0x5A171E0", VA = "0x185A185E0", Slot = "42")]
		protected virtual void UpdateMaterial()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x5A185C0", Offset = "0x5A171C0", VA = "0x185A185C0", Slot = "43")]
		protected virtual void UpdateGeometry()
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x5A163F0", Offset = "0x5A14FF0", VA = "0x185A163F0")]
		private void DoMeshGeneration()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x5A15F70", Offset = "0x5A14B70", VA = "0x185A15F70")]
		private void DoLegacyMeshGeneration()
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		protected static Mesh workerMesh
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x5A19020", Offset = "0x5A17C20", VA = "0x185A19020")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "44")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use OnPopulateMesh instead.", true)]
		protected virtual void OnFillVBO(List<UIVertex> vbo)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x5A172E0", Offset = "0x5A15EE0", VA = "0x185A172E0", Slot = "45")]
		[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", false)]
		protected virtual void OnPopulateMesh(Mesh m)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x5A173A0", Offset = "0x5A15FA0", VA = "0x185A173A0", Slot = "46")]
		protected virtual void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x4F831F0", Offset = "0x4F81DF0", VA = "0x184F831F0", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "47")]
		public virtual void SetNativeSize()
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x5A179A0", Offset = "0x5A165A0", VA = "0x185A179A0", Slot = "48")]
		public virtual bool Raycast(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x5A17810", Offset = "0x5A16410", VA = "0x185A17810")]
		public Vector2 PixelAdjustPoint(Vector2 point)
		{
			return default(Vector2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x5A168C0", Offset = "0x5A154C0", VA = "0x185A168C0")]
		public Rect GetPixelAdjustedRect()
		{
			return default(Rect);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x5A15EE0", Offset = "0x5A14AE0", VA = "0x185A15EE0", Slot = "49")]
		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x5A15C30", Offset = "0x5A14830", VA = "0x185A15C30", Slot = "50")]
		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x5A15B40", Offset = "0x5A14740", VA = "0x185A15B40")]
		private static Color CreateColorFromAlpha(float alpha)
		{
			return default(Color);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x5A15B60", Offset = "0x5A14760", VA = "0x185A15B60", Slot = "51")]
		public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x5A17DD0", Offset = "0x5A169D0", VA = "0x185A17DD0")]
		public void RegisterDirtyLayoutCallback(UnityAction action)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x5A183E0", Offset = "0x5A16FE0", VA = "0x185A183E0")]
		public void UnregisterDirtyLayoutCallback(UnityAction action)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x5A17F10", Offset = "0x5A16B10", VA = "0x185A17F10")]
		public void RegisterDirtyVerticesCallback(UnityAction action)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x5A18520", Offset = "0x5A17120", VA = "0x185A18520")]
		public void UnregisterDirtyVerticesCallback(UnityAction action)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x5A17E70", Offset = "0x5A16A70", VA = "0x185A17E70")]
		public void RegisterDirtyMaterialCallback(UnityAction action)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x5A18480", Offset = "0x5A17080", VA = "0x185A18480")]
		public void UnregisterDirtyMaterialCallback(UnityAction action)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x589F680", Offset = "0x589E280", VA = "0x18589F680", Slot = "18")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x0")]
		protected static Material s_DefaultUI;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x8")]
		protected static Texture2D s_WhiteTexture;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_Mat")]
		[SerializeField]
		protected Material m_Material;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color m_Color;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		protected bool m_SkipLayoutUpdate;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x31")]
		[NonSerialized]
		protected bool m_SkipMaterialUpdate;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool m_RaycastTarget;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x33")]
		private bool m_RaycastTargetCache;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector4 m_RaycastPadding;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private CanvasRenderer m_CanvasRenderer;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private Canvas m_Canvas;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private bool m_VertsDirty;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x61")]
		[NonSerialized]
		private bool m_MaterialDirty;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		protected UnityAction m_OnDirtyLayoutCallback;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		protected UnityAction m_OnDirtyVertsCallback;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		protected UnityAction m_OnDirtyMaterialCallback;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		protected static Mesh s_Mesh;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private static readonly VertexHelper s_VertexHelper;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		protected Mesh m_CachedMesh;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		protected Vector2[] m_CachedUvs;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		private readonly TweenRunner<ColorTween> m_ColorTweenRunner;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		protected bool m_EnableRuntimeAtlas;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		protected Texture m_RuntimeAtlasTexture;
	}
}
