using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SoftMasking
{
	// Token: 0x0200043B RID: 1083
	[Token(Token = "0x200043B")]
	[HelpURL("https://docs.google.com/document/d/1SkD4yjjD-F6OVMoUtTYTiINHLBpasdfcSQS6XDFq8EQ")]
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Soft Mask", 14)]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class SoftMask : UIBehaviour, ISoftMask, ICanvasRaycastFilter
	{
		// Token: 0x06004981 RID: 18817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004981")]
		[Address(RVA = "0x157C980", Offset = "0x157B580", VA = "0x18157C980")]
		public SoftMask()
		{
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06004982 RID: 18818 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004983 RID: 18819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000166")]
		public Shader defaultShader
		{
			[Token(Token = "0x6004982")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004983")]
			[Address(RVA = "0x157D050", Offset = "0x157BC50", VA = "0x18157D050")]
			set
			{
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06004984 RID: 18820 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004985 RID: 18821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000167")]
		public Shader defaultETC1Shader
		{
			[Token(Token = "0x6004984")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004985")]
			[Address(RVA = "0x157D020", Offset = "0x157BC20", VA = "0x18157D020")]
			set
			{
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06004986 RID: 18822 RVA: 0x0002C1A8 File Offset: 0x0002A3A8
		// (set) Token: 0x06004987 RID: 18823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000168")]
		public SoftMask.MaskSource source
		{
			[Token(Token = "0x6004986")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return SoftMask.MaskSource.Graphic;
			}
			[Token(Token = "0x6004987")]
			[Address(RVA = "0x157D150", Offset = "0x157BD50", VA = "0x18157D150")]
			set
			{
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06004988 RID: 18824 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004989 RID: 18825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000169")]
		public RectTransform separateMask
		{
			[Token(Token = "0x6004988")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004989")]
			[Address(RVA = "0x157D090", Offset = "0x157BC90", VA = "0x18157D090")]
			set
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600498A RID: 18826 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600498B RID: 18827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016A")]
		public Sprite sprite
		{
			[Token(Token = "0x600498A")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x600498B")]
			[Address(RVA = "0x157D210", Offset = "0x157BE10", VA = "0x18157D210")]
			set
			{
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600498C RID: 18828 RVA: 0x0002C1C0 File Offset: 0x0002A3C0
		// (set) Token: 0x0600498D RID: 18829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016B")]
		public SoftMask.BorderMode spriteBorderMode
		{
			[Token(Token = "0x600498C")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			get
			{
				return SoftMask.BorderMode.Simple;
			}
			[Token(Token = "0x600498D")]
			[Address(RVA = "0x157D1B0", Offset = "0x157BDB0", VA = "0x18157D1B0")]
			set
			{
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600498E RID: 18830 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600498F RID: 18831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016C")]
		public Texture2D texture
		{
			[Token(Token = "0x600498E")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x600498F")]
			[Address(RVA = "0x157D340", Offset = "0x157BF40", VA = "0x18157D340")]
			set
			{
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06004990 RID: 18832 RVA: 0x0002C1D8 File Offset: 0x0002A3D8
		// (set) Token: 0x06004991 RID: 18833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016D")]
		public Rect textureUVRect
		{
			[Token(Token = "0x6004990")]
			[Address(RVA = "0x157CF50", Offset = "0x157BB50", VA = "0x18157CF50")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6004991")]
			[Address(RVA = "0x157D2B0", Offset = "0x157BEB0", VA = "0x18157D2B0")]
			set
			{
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06004992 RID: 18834 RVA: 0x0002C1F0 File Offset: 0x0002A3F0
		// (set) Token: 0x06004993 RID: 18835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016E")]
		public Color channelWeights
		{
			[Token(Token = "0x6004992")]
			[Address(RVA = "0x157CDD0", Offset = "0x157B9D0", VA = "0x18157CDD0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6004993")]
			[Address(RVA = "0x157CF60", Offset = "0x157BB60", VA = "0x18157CF60")]
			set
			{
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06004994 RID: 18836 RVA: 0x0002C208 File Offset: 0x0002A408
		// (set) Token: 0x06004995 RID: 18837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016F")]
		public float raycastThreshold
		{
			[Token(Token = "0x6004994")]
			[Address(RVA = "0x157CF40", Offset = "0x157BB40", VA = "0x18157CF40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004995")]
			[Address(RVA = "0x157D080", Offset = "0x157BC80", VA = "0x18157D080")]
			set
			{
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06004996 RID: 18838 RVA: 0x0002C220 File Offset: 0x0002A420
		[Token(Token = "0x17000170")]
		public bool isMaskingEnabled
		{
			[Token(Token = "0x6004996")]
			[Address(RVA = "0x157CDF0", Offset = "0x157B9F0", VA = "0x18157CDF0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x0002C238 File Offset: 0x0002A438
		[Token(Token = "0x6004997")]
		[Address(RVA = "0x157BE10", Offset = "0x157AA10", VA = "0x18157BE10")]
		public SoftMask.Errors PollErrors()
		{
			return SoftMask.Errors.NoError;
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x0002C250 File Offset: 0x0002A450
		[Token(Token = "0x6004998")]
		[Address(RVA = "0x157B2C0", Offset = "0x1579EC0", VA = "0x18157B2C0", Slot = "22")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera cam)
		{
			return default(bool);
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004999")]
		[Address(RVA = "0x157C2D0", Offset = "0x157AED0", VA = "0x18157C2D0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600499A")]
		[Address(RVA = "0x157BC00", Offset = "0x157A800", VA = "0x18157BC00", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600499B")]
		[Address(RVA = "0x157BAA0", Offset = "0x157A6A0", VA = "0x18157BAA0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600499C")]
		[Address(RVA = "0x157BA50", Offset = "0x157A650", VA = "0x18157BA50", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600499D")]
		[Address(RVA = "0x157B4E0", Offset = "0x157A0E0", VA = "0x18157B4E0", Slot = "23")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600499E")]
		[Address(RVA = "0x157BCC0", Offset = "0x157A8C0", VA = "0x18157BCC0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600499F")]
		[Address(RVA = "0x157BA80", Offset = "0x157A680", VA = "0x18157BA80", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A0")]
		[Address(RVA = "0x157BDD0", Offset = "0x157A9D0", VA = "0x18157BDD0", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A1")]
		[Address(RVA = "0x157BA10", Offset = "0x157A610", VA = "0x18157BA10", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A2")]
		[Address(RVA = "0x157BDA0", Offset = "0x157A9A0", VA = "0x18157BDA0")]
		private void OnTransformChildrenChanged()
		{
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060049A3 RID: 18851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000171")]
		private RectTransform maskTransform
		{
			[Token(Token = "0x60049A3")]
			[Address(RVA = "0x157CE60", Offset = "0x157BA60", VA = "0x18157CE60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060049A4 RID: 18852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000172")]
		private Canvas canvas
		{
			[Token(Token = "0x60049A4")]
			[Address(RVA = "0x157CCB0", Offset = "0x157B8B0", VA = "0x18157CCB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x0002C268 File Offset: 0x0002A468
		[Token(Token = "0x17000173")]
		private bool isBasedOnGraphic
		{
			[Token(Token = "0x60049A5")]
			[Address(RVA = "0x157CDE0", Offset = "0x157B9E0", VA = "0x18157CDE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060049A6 RID: 18854 RVA: 0x0002C280 File Offset: 0x0002A480
		[Token(Token = "0x17000174")]
		private bool isAlive
		{
			[Token(Token = "0x60049A6")]
			[Address(RVA = "0x157C170", Offset = "0x157AD70", VA = "0x18157C170", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A7")]
		[Address(RVA = "0x157BFF0", Offset = "0x157ABF0", VA = "0x18157BFF0", Slot = "19")]
		private Material GetReplacement(Material original)
		{
			return null;
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A8")]
		[Address(RVA = "0x157C010", Offset = "0x157AC10", VA = "0x18157C010", Slot = "20")]
		private void ReleaseReplacement(Material replacement)
		{
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A9")]
		[Address(RVA = "0x157C160", Offset = "0x157AD60", VA = "0x18157C160", Slot = "21")]
		private void UpdateTransformChildren(Transform transform)
		{
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049AA")]
		[Address(RVA = "0x157BCB0", Offset = "0x157A8B0", VA = "0x18157BCB0")]
		private void OnGraphicDirty()
		{
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049AB")]
		[Address(RVA = "0x157AD60", Offset = "0x1579960", VA = "0x18157AD60")]
		private void FindGraphic()
		{
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AC")]
		[Address(RVA = "0x157B860", Offset = "0x157A460", VA = "0x18157B860")]
		private Canvas NearestEnabledCanvas()
		{
			return null;
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049AD")]
		[Address(RVA = "0x157C460", Offset = "0x157B060", VA = "0x18157C460")]
		private void UpdateMaskParameters()
		{
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049AE")]
		[Address(RVA = "0x157C1D0", Offset = "0x157ADD0", VA = "0x18157C1D0")]
		private void SpawnMaskablesInChildren(Transform root)
		{
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049AF")]
		[Address(RVA = "0x157B1B0", Offset = "0x1579DB0", VA = "0x18157B1B0")]
		private void InvalidateChildren()
		{
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B0")]
		[Address(RVA = "0x157B900", Offset = "0x157A500", VA = "0x18157B900")]
		private void NotifyChildrenThatMaskMightChanged()
		{
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B1")]
		[Address(RVA = "0x157AEE0", Offset = "0x1579AE0", VA = "0x18157AEE0")]
		private void ForEachChildMaskable(Action<SoftMaskable> f)
		{
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B2")]
		[Address(RVA = "0x157AAC0", Offset = "0x15796C0", VA = "0x18157AAC0")]
		private void DestroyMaterials()
		{
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B3")]
		[Address(RVA = "0x1579B50", Offset = "0x1578750", VA = "0x181579B50")]
		private void CalculateMaskParameters()
		{
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x0002C298 File Offset: 0x0002A498
		[Token(Token = "0x60049B4")]
		[Address(RVA = "0x157C2F0", Offset = "0x157AEF0", VA = "0x18157C2F0")]
		private SoftMask.BorderMode ToBorderMode(Image.Type imageType)
		{
			return SoftMask.BorderMode.Simple;
		}

		// Token: 0x060049B5 RID: 18869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B5")]
		[Address(RVA = "0x15799D0", Offset = "0x15785D0", VA = "0x1815799D0")]
		private void CalculateImageBased(Image image)
		{
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B6")]
		[Address(RVA = "0x1579F80", Offset = "0x1578B80", VA = "0x181579F80")]
		private void CalculateRawImageBased(RawImage image)
		{
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B7")]
		[Address(RVA = "0x157A070", Offset = "0x1578C70", VA = "0x18157A070")]
		private void CalculateSpriteBased(Sprite sprite, SoftMask.BorderMode borderMode)
		{
		}

		// Token: 0x060049B8 RID: 18872 RVA: 0x0002C2B0 File Offset: 0x0002A4B0
		[Token(Token = "0x60049B8")]
		[Address(RVA = "0x15797D0", Offset = "0x15783D0", VA = "0x1815797D0")]
		private static Vector4 AdjustBorders(Vector4 border, Vector4 rect)
		{
			return default(Vector4);
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B9")]
		[Address(RVA = "0x157A8F0", Offset = "0x15794F0", VA = "0x18157A8F0")]
		private void CalculateTextureBased(Texture2D texture, Rect uvRect)
		{
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049BA")]
		[Address(RVA = "0x157A000", Offset = "0x1578C00", VA = "0x18157A000")]
		private void CalculateSolidFill()
		{
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049BB")]
		[Address(RVA = "0x157ABD0", Offset = "0x15797D0", VA = "0x18157ABD0")]
		private void FillCommonParameters()
		{
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x0002C2C8 File Offset: 0x0002A4C8
		[Token(Token = "0x60049BC")]
		[Address(RVA = "0x157B0C0", Offset = "0x1579CC0", VA = "0x18157B0C0")]
		private float GraphicToCanvasScale(Sprite sprite)
		{
			return 0f;
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x0002C2E0 File Offset: 0x0002A4E0
		[Token(Token = "0x60049BD")]
		[Address(RVA = "0x157C6D0", Offset = "0x157B2D0", VA = "0x18157C6D0")]
		private Matrix4x4 WorldToMask()
		{
			return default(Matrix4x4);
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x0002C2F8 File Offset: 0x0002A4F8
		[Token(Token = "0x60049BE")]
		[Address(RVA = "0x157B5F0", Offset = "0x157A1F0", VA = "0x18157B5F0")]
		private Vector4 LocalMaskRect(Vector4 border)
		{
			return default(Vector4);
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x0002C310 File Offset: 0x0002A510
		[Token(Token = "0x60049BF")]
		[Address(RVA = "0x157B6F0", Offset = "0x157A2F0", VA = "0x18157B6F0")]
		private Vector2 MaskRepeat(Sprite sprite, Vector4 centralPart)
		{
			return default(Vector2);
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C0")]
		[Address(RVA = "0x157C580", Offset = "0x157B180", VA = "0x18157C580")]
		private void WarnIfDefaultShaderIsNotSet()
		{
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C1")]
		[Address(RVA = "0x157C620", Offset = "0x157B220", VA = "0x18157C620")]
		private void WarnSpriteErrors(SoftMask.Errors errors)
		{
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C2")]
		private void Set<T>(ref T field, T value)
		{
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C3")]
		[Address(RVA = "0x157BE50", Offset = "0x157AA50", VA = "0x18157BE50")]
		private void SetShader(ref Shader field, Shader value, bool warnIfNotSet = true)
		{
		}

		// Token: 0x04000E10 RID: 3600
		[Token(Token = "0x4000E10")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Shader _defaultShader;

		// Token: 0x04000E11 RID: 3601
		[Token(Token = "0x4000E11")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Shader _defaultETC1Shader;

		// Token: 0x04000E12 RID: 3602
		[Token(Token = "0x4000E12")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SoftMask.MaskSource _source;

		// Token: 0x04000E13 RID: 3603
		[Token(Token = "0x4000E13")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _separateMask;

		// Token: 0x04000E14 RID: 3604
		[Token(Token = "0x4000E14")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _sprite;

		// Token: 0x04000E15 RID: 3605
		[Token(Token = "0x4000E15")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SoftMask.BorderMode _spriteBorderMode;

		// Token: 0x04000E16 RID: 3606
		[Token(Token = "0x4000E16")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Texture2D _texture;

		// Token: 0x04000E17 RID: 3607
		[Token(Token = "0x4000E17")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Rect _textureUVRect;

		// Token: 0x04000E18 RID: 3608
		[Token(Token = "0x4000E18")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _channelWeights;

		// Token: 0x04000E19 RID: 3609
		[Token(Token = "0x4000E19")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _raycastThreshold;

		// Token: 0x04000E1A RID: 3610
		[Token(Token = "0x4000E1A")]
		[FieldOffset(Offset = "0x78")]
		private MaterialReplacements _materials;

		// Token: 0x04000E1B RID: 3611
		[Token(Token = "0x4000E1B")]
		[FieldOffset(Offset = "0x80")]
		private SoftMask.MaterialParameters _parameters;

		// Token: 0x04000E1C RID: 3612
		[Token(Token = "0x4000E1C")]
		[FieldOffset(Offset = "0x130")]
		private Sprite _lastUsedSprite;

		// Token: 0x04000E1D RID: 3613
		[Token(Token = "0x4000E1D")]
		[FieldOffset(Offset = "0x138")]
		private bool _maskingWasEnabled;

		// Token: 0x04000E1E RID: 3614
		[Token(Token = "0x4000E1E")]
		[FieldOffset(Offset = "0x139")]
		private bool _destroyed;

		// Token: 0x04000E1F RID: 3615
		[Token(Token = "0x4000E1F")]
		[FieldOffset(Offset = "0x13A")]
		private bool _dirty;

		// Token: 0x04000E20 RID: 3616
		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0x140")]
		private RectTransform _maskTransform;

		// Token: 0x04000E21 RID: 3617
		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0x148")]
		private Graphic _graphic;

		// Token: 0x04000E22 RID: 3618
		[Token(Token = "0x4000E22")]
		[FieldOffset(Offset = "0x150")]
		private Canvas _canvas;

		// Token: 0x04000E23 RID: 3619
		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Rect DefaultUVRect;

		// Token: 0x04000E24 RID: 3620
		[Token(Token = "0x4000E24")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<SoftMask> s_masks;

		// Token: 0x04000E25 RID: 3621
		[Token(Token = "0x4000E25")]
		[FieldOffset(Offset = "0x18")]
		private static readonly List<SoftMaskable> s_maskables;

		// Token: 0x0200043C RID: 1084
		[Token(Token = "0x200043C")]
		[Serializable]
		public enum MaskSource
		{
			// Token: 0x04000E27 RID: 3623
			[Token(Token = "0x4000E27")]
			Graphic,
			// Token: 0x04000E28 RID: 3624
			[Token(Token = "0x4000E28")]
			Sprite,
			// Token: 0x04000E29 RID: 3625
			[Token(Token = "0x4000E29")]
			Texture
		}

		// Token: 0x0200043D RID: 1085
		[Token(Token = "0x200043D")]
		[Serializable]
		public enum BorderMode
		{
			// Token: 0x04000E2B RID: 3627
			[Token(Token = "0x4000E2B")]
			Simple,
			// Token: 0x04000E2C RID: 3628
			[Token(Token = "0x4000E2C")]
			Sliced,
			// Token: 0x04000E2D RID: 3629
			[Token(Token = "0x4000E2D")]
			Tiled
		}

		// Token: 0x0200043E RID: 1086
		[Token(Token = "0x200043E")]
		[Flags]
		[Serializable]
		public enum Errors
		{
			// Token: 0x04000E2F RID: 3631
			[Token(Token = "0x4000E2F")]
			NoError = 0,
			// Token: 0x04000E30 RID: 3632
			[Token(Token = "0x4000E30")]
			UnsupportedShaders = 1,
			// Token: 0x04000E31 RID: 3633
			[Token(Token = "0x4000E31")]
			NestedMasks = 2,
			// Token: 0x04000E32 RID: 3634
			[Token(Token = "0x4000E32")]
			TightPackedSprite = 4,
			// Token: 0x04000E33 RID: 3635
			[Token(Token = "0x4000E33")]
			AlphaSplitSprite = 8,
			// Token: 0x04000E34 RID: 3636
			[Token(Token = "0x4000E34")]
			UnsupportedImageType = 16
		}

		// Token: 0x0200043F RID: 1087
		[Token(Token = "0x200043F")]
		private class MaterialReplacerImpl : IMaterialReplacer
		{
			// Token: 0x060049C6 RID: 18886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60049C6")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public MaterialReplacerImpl(SoftMask owner)
			{
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x060049C7 RID: 18887 RVA: 0x0002C328 File Offset: 0x0002A528
			[Token(Token = "0x17000175")]
			public int order
			{
				[Token(Token = "0x60049C7")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060049C8 RID: 18888 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60049C8")]
			[Address(RVA = "0x1578A10", Offset = "0x1577610", VA = "0x181578A10", Slot = "5")]
			public Material Replace(Material original)
			{
				return null;
			}

			// Token: 0x060049C9 RID: 18889 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60049C9")]
			[Address(RVA = "0x1578910", Offset = "0x1577510", VA = "0x181578910")]
			private static Material Replace(Material original, Shader defaultReplacementShader)
			{
				return null;
			}

			// Token: 0x04000E35 RID: 3637
			[Token(Token = "0x4000E35")]
			[FieldOffset(Offset = "0x10")]
			private readonly SoftMask _owner;
		}

		// Token: 0x02000440 RID: 1088
		[Token(Token = "0x2000440")]
		private static class Mathr
		{
			// Token: 0x060049CA RID: 18890 RVA: 0x0002C340 File Offset: 0x0002A540
			[Token(Token = "0x60049CA")]
			[Address(RVA = "0x1579740", Offset = "0x1578340", VA = "0x181579740")]
			public static Vector4 ToVector(Rect r)
			{
				return default(Vector4);
			}

			// Token: 0x060049CB RID: 18891 RVA: 0x0002C358 File Offset: 0x0002A558
			[Token(Token = "0x60049CB")]
			[Address(RVA = "0x15794D0", Offset = "0x15780D0", VA = "0x1815794D0")]
			public static Vector4 Div(Vector4 v, Vector2 s)
			{
				return default(Vector4);
			}

			// Token: 0x060049CC RID: 18892 RVA: 0x0002C370 File Offset: 0x0002A570
			[Token(Token = "0x60049CC")]
			[Address(RVA = "0x1579520", Offset = "0x1578120", VA = "0x181579520")]
			public static Vector2 Div(Vector2 v, Vector2 s)
			{
				return default(Vector2);
			}

			// Token: 0x060049CD RID: 18893 RVA: 0x0002C388 File Offset: 0x0002A588
			[Token(Token = "0x60049CD")]
			[Address(RVA = "0x1579630", Offset = "0x1578230", VA = "0x181579630")]
			public static Vector4 Mul(Vector4 v, Vector2 s)
			{
				return default(Vector4);
			}

			// Token: 0x060049CE RID: 18894 RVA: 0x0002C3A0 File Offset: 0x0002A5A0
			[Token(Token = "0x60049CE")]
			[Address(RVA = "0x1579720", Offset = "0x1578320", VA = "0x181579720")]
			public static Vector2 Size(Vector4 r)
			{
				return default(Vector2);
			}

			// Token: 0x060049CF RID: 18895 RVA: 0x0002C3B8 File Offset: 0x0002A5B8
			[Token(Token = "0x60049CF")]
			[Address(RVA = "0x15795E0", Offset = "0x15781E0", VA = "0x1815795E0")]
			public static Vector4 Move(Vector4 v, Vector2 o)
			{
				return default(Vector4);
			}

			// Token: 0x060049D0 RID: 18896 RVA: 0x0002C3D0 File Offset: 0x0002A5D0
			[Token(Token = "0x60049D0")]
			[Address(RVA = "0x1579480", Offset = "0x1578080", VA = "0x181579480")]
			public static Vector4 BorderOf(Vector4 outer, Vector4 inner)
			{
				return default(Vector4);
			}

			// Token: 0x060049D1 RID: 18897 RVA: 0x0002C3E8 File Offset: 0x0002A5E8
			[Token(Token = "0x60049D1")]
			[Address(RVA = "0x1579430", Offset = "0x1578030", VA = "0x181579430")]
			public static Vector4 ApplyBorder(Vector4 v, Vector4 b)
			{
				return default(Vector4);
			}

			// Token: 0x060049D2 RID: 18898 RVA: 0x0002C400 File Offset: 0x0002A600
			[Token(Token = "0x60049D2")]
			[Address(RVA = "0x15795C0", Offset = "0x15781C0", VA = "0x1815795C0")]
			public static Vector2 Min(Vector4 r)
			{
				return default(Vector2);
			}

			// Token: 0x060049D3 RID: 18899 RVA: 0x0002C418 File Offset: 0x0002A618
			[Token(Token = "0x60049D3")]
			[Address(RVA = "0x15795A0", Offset = "0x15781A0", VA = "0x1815795A0")]
			public static Vector2 Max(Vector4 r)
			{
				return default(Vector2);
			}

			// Token: 0x060049D4 RID: 18900 RVA: 0x0002C430 File Offset: 0x0002A630
			[Token(Token = "0x60049D4")]
			[Address(RVA = "0x1579680", Offset = "0x1578280", VA = "0x181579680")]
			public static Vector2 Remap(Vector2 c, Vector4 r1, Vector4 r2)
			{
				return default(Vector2);
			}

			// Token: 0x060049D5 RID: 18901 RVA: 0x0002C448 File Offset: 0x0002A648
			[Token(Token = "0x60049D5")]
			[Address(RVA = "0x1579560", Offset = "0x1578160", VA = "0x181579560")]
			public static bool Inside(Vector2 v, Vector4 r)
			{
				return default(bool);
			}
		}

		// Token: 0x02000441 RID: 1089
		[Token(Token = "0x2000441")]
		private struct MaterialParameters
		{
			// Token: 0x17000176 RID: 374
			// (get) Token: 0x060049D6 RID: 18902 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000176")]
			public Texture2D activeTexture
			{
				[Token(Token = "0x60049D6")]
				[Address(RVA = "0x1687D70", Offset = "0x1686970", VA = "0x181687D70")]
				get
				{
					return null;
				}
			}

			// Token: 0x060049D7 RID: 18903 RVA: 0x0002C460 File Offset: 0x0002A660
			[Token(Token = "0x60049D7")]
			[Address(RVA = "0x1687BA0", Offset = "0x16867A0", VA = "0x181687BA0")]
			public bool SampleMask(Vector2 localPos, out float mask)
			{
				return default(bool);
			}

			// Token: 0x060049D8 RID: 18904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60049D8")]
			[Address(RVA = "0x16874B0", Offset = "0x16860B0", VA = "0x1816874B0")]
			public void Apply(Material mat)
			{
			}

			// Token: 0x060049D9 RID: 18905 RVA: 0x0002C478 File Offset: 0x0002A678
			[Token(Token = "0x60049D9")]
			[Address(RVA = "0x1687C70", Offset = "0x1686870", VA = "0x181687C70")]
			private Vector2 XY2UV(Vector2 localPos)
			{
				return default(Vector2);
			}

			// Token: 0x060049DA RID: 18906 RVA: 0x0002C490 File Offset: 0x0002A690
			[Token(Token = "0x60049DA")]
			[Address(RVA = "0x1687B10", Offset = "0x1686710", VA = "0x181687B10")]
			private Vector2 MapSimple(Vector2 localPos)
			{
				return default(Vector2);
			}

			// Token: 0x060049DB RID: 18907 RVA: 0x0002C4A8 File Offset: 0x0002A6A8
			[Token(Token = "0x60049DB")]
			[Address(RVA = "0x16879C0", Offset = "0x16865C0", VA = "0x1816879C0")]
			private Vector2 MapBorder(Vector2 localPos, bool repeat)
			{
				return default(Vector2);
			}

			// Token: 0x060049DC RID: 18908 RVA: 0x0002C4C0 File Offset: 0x0002A6C0
			[Token(Token = "0x60049DC")]
			[Address(RVA = "0x1687940", Offset = "0x1686540", VA = "0x181687940")]
			private float Inset(float v, float x1, float x2, float u1, float u2, float repeat = 1f)
			{
				return 0f;
			}

			// Token: 0x060049DD RID: 18909 RVA: 0x0002C4D8 File Offset: 0x0002A6D8
			[Token(Token = "0x60049DD")]
			[Address(RVA = "0x16877C0", Offset = "0x16863C0", VA = "0x1816877C0")]
			private float Inset(float v, float x1, float x2, float x3, float x4, float u1, float u2, float u3, float u4, float repeat = 1f)
			{
				return 0f;
			}

			// Token: 0x060049DE RID: 18910 RVA: 0x0002C4F0 File Offset: 0x0002A6F0
			[Token(Token = "0x60049DE")]
			[Address(RVA = "0x1687790", Offset = "0x1686390", VA = "0x181687790")]
			private float Frac(float v)
			{
				return 0f;
			}

			// Token: 0x060049DF RID: 18911 RVA: 0x0002C508 File Offset: 0x0002A708
			[Token(Token = "0x60049DF")]
			[Address(RVA = "0x1687B50", Offset = "0x1686750", VA = "0x181687B50")]
			private float MaskValue(Color mask)
			{
				return 0f;
			}

			// Token: 0x04000E36 RID: 3638
			[Token(Token = "0x4000E36")]
			[FieldOffset(Offset = "0x0")]
			public Vector4 maskRect;

			// Token: 0x04000E37 RID: 3639
			[Token(Token = "0x4000E37")]
			[FieldOffset(Offset = "0x10")]
			public Vector4 maskBorder;

			// Token: 0x04000E38 RID: 3640
			[Token(Token = "0x4000E38")]
			[FieldOffset(Offset = "0x20")]
			public Vector4 maskRectUV;

			// Token: 0x04000E39 RID: 3641
			[Token(Token = "0x4000E39")]
			[FieldOffset(Offset = "0x30")]
			public Vector4 maskBorderUV;

			// Token: 0x04000E3A RID: 3642
			[Token(Token = "0x4000E3A")]
			[FieldOffset(Offset = "0x40")]
			public Vector2 tileRepeat;

			// Token: 0x04000E3B RID: 3643
			[Token(Token = "0x4000E3B")]
			[FieldOffset(Offset = "0x48")]
			public Color maskChannelWeights;

			// Token: 0x04000E3C RID: 3644
			[Token(Token = "0x4000E3C")]
			[FieldOffset(Offset = "0x58")]
			public Matrix4x4 worldToMask;

			// Token: 0x04000E3D RID: 3645
			[Token(Token = "0x4000E3D")]
			[FieldOffset(Offset = "0x98")]
			public float scalerFactor;

			// Token: 0x04000E3E RID: 3646
			[Token(Token = "0x4000E3E")]
			[FieldOffset(Offset = "0xA0")]
			public Texture2D texture;

			// Token: 0x04000E3F RID: 3647
			[Token(Token = "0x4000E3F")]
			[FieldOffset(Offset = "0xA8")]
			public SoftMask.BorderMode borderMode;

			// Token: 0x02000442 RID: 1090
			[Token(Token = "0x2000442")]
			private static class Ids
			{
				// Token: 0x04000E40 RID: 3648
				[Token(Token = "0x4000E40")]
				[FieldOffset(Offset = "0x0")]
				public static readonly int SoftMask;

				// Token: 0x04000E41 RID: 3649
				[Token(Token = "0x4000E41")]
				[FieldOffset(Offset = "0x4")]
				public static readonly int SoftMask_Rect;

				// Token: 0x04000E42 RID: 3650
				[Token(Token = "0x4000E42")]
				[FieldOffset(Offset = "0x8")]
				public static readonly int SoftMask_UVRect;

				// Token: 0x04000E43 RID: 3651
				[Token(Token = "0x4000E43")]
				[FieldOffset(Offset = "0xC")]
				public static readonly int SoftMask_ChannelWeights;

				// Token: 0x04000E44 RID: 3652
				[Token(Token = "0x4000E44")]
				[FieldOffset(Offset = "0x10")]
				public static readonly int SoftMask_WorldToMask;

				// Token: 0x04000E45 RID: 3653
				[Token(Token = "0x4000E45")]
				[FieldOffset(Offset = "0x14")]
				public static readonly int SoftMask_BorderRect;

				// Token: 0x04000E46 RID: 3654
				[Token(Token = "0x4000E46")]
				[FieldOffset(Offset = "0x18")]
				public static readonly int SoftMask_UVBorderRect;

				// Token: 0x04000E47 RID: 3655
				[Token(Token = "0x4000E47")]
				[FieldOffset(Offset = "0x1C")]
				public static readonly int SoftMask_TileRepeat;
			}
		}

		// Token: 0x02000443 RID: 1091
		[Token(Token = "0x2000443")]
		private struct Diagnostics
		{
			// Token: 0x060049E1 RID: 18913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60049E1")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public Diagnostics(SoftMask softMask)
			{
			}

			// Token: 0x060049E2 RID: 18914 RVA: 0x0002C520 File Offset: 0x0002A720
			[Token(Token = "0x60049E2")]
			[Address(RVA = "0x1680420", Offset = "0x167F020", VA = "0x181680420")]
			public SoftMask.Errors PollErrors()
			{
				return SoftMask.Errors.NoError;
			}

			// Token: 0x060049E3 RID: 18915 RVA: 0x0002C538 File Offset: 0x0002A738
			[Token(Token = "0x60049E3")]
			[Address(RVA = "0x1680350", Offset = "0x167EF50", VA = "0x181680350")]
			public static SoftMask.Errors CheckSprite(Sprite sprite)
			{
				return SoftMask.Errors.NoError;
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x060049E4 RID: 18916 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000177")]
			private Image image
			{
				[Token(Token = "0x60049E4")]
				[Address(RVA = "0x1680840", Offset = "0x167F440", VA = "0x181680840")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x060049E5 RID: 18917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000178")]
			private Sprite sprite
			{
				[Token(Token = "0x60049E5")]
				[Address(RVA = "0x1680900", Offset = "0x167F500", VA = "0x181680900")]
				get
				{
					return null;
				}
			}

			// Token: 0x060049E6 RID: 18918 RVA: 0x0002C550 File Offset: 0x0002A750
			[Token(Token = "0x60049E6")]
			[Address(RVA = "0x1680650", Offset = "0x167F250", VA = "0x181680650")]
			private bool ThereAreNestedMasks()
			{
				return default(bool);
			}

			// Token: 0x060049E7 RID: 18919 RVA: 0x0002C568 File Offset: 0x0002A768
			[Token(Token = "0x60049E7")]
			[Address(RVA = "0x1680290", Offset = "0x167EE90", VA = "0x181680290")]
			private SoftMask.Errors CheckImage()
			{
				return SoftMask.Errors.NoError;
			}

			// Token: 0x060049E8 RID: 18920 RVA: 0x0002C580 File Offset: 0x0002A780
			[Token(Token = "0x60049E8")]
			[Address(RVA = "0x1680120", Offset = "0x167ED20", VA = "0x181680120")]
			private static bool AreCompeting(SoftMask softMask, SoftMask other)
			{
				return default(bool);
			}

			// Token: 0x060049E9 RID: 18921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60049E9")]
			private static T Child<T>(T first, T second) where T : Component
			{
				return null;
			}

			// Token: 0x04000E48 RID: 3656
			[Token(Token = "0x4000E48")]
			[FieldOffset(Offset = "0x0")]
			private SoftMask _softMask;
		}
	}
}
