using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	[ExecuteAlways]
	[HelpURL("http://esotericsoftware.com/spine-unity#BoundingBoxFollowerGraphic")]
	public class BoundingBoxFollowerGraphic : MonoBehaviour
	{
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000188")]
		public Slot Slot
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000189")]
		public BoundingBoxAttachment CurrentAttachment
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700018A")]
		public string CurrentAttachmentName
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700018B")]
		public PolygonCollider2D CurrentCollider
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x000040F4 File Offset: 0x000022F4
		[Token(Token = "0x1700018C")]
		public bool IsTrigger
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x4E77BD0", Offset = "0x4E767D0", VA = "0x184E77BD0")]
		private void Start()
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x4E78760", Offset = "0x4E77360", VA = "0x184E78760")]
		private void OnEnable()
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x4E77BD0", Offset = "0x4E767D0", VA = "0x184E77BD0")]
		private void HandleRebuild(SkeletonGraphic sr)
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x4E77BE0", Offset = "0x4E767E0", VA = "0x184E77BE0")]
		public void Initialize(bool overwrite = false)
		{
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x4E77540", Offset = "0x4E76140", VA = "0x184E77540")]
		private void AddCollidersForSkin(Skin skin, int slotIndex, PolygonCollider2D[] previousColliders, float scale, ref int collidersCount)
		{
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x4E78680", Offset = "0x4E77280", VA = "0x184E78680")]
		private void OnDisable()
		{
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x4E77960", Offset = "0x4E76560", VA = "0x184E77960")]
		public void ClearState()
		{
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x4E77AF0", Offset = "0x4E766F0", VA = "0x184E77AF0")]
		private void DisposeExcessCollidersAfter(int requiredCount)
		{
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x4E782E0", Offset = "0x4E76EE0", VA = "0x184E782E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x4E78300", Offset = "0x4E76F00", VA = "0x184E78300")]
		private void MatchAttachment(Attachment attachment)
		{
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x4E78950", Offset = "0x4E77550", VA = "0x184E78950")]
		public BoundingBoxFollowerGraphic()
		{
		}

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x0")]
		internal static bool DebugMessages;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x18")]
		public SkeletonGraphic skeletonGraphic;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x20")]
		[SpineSlot("", "skeletonGraphic", true, true, false)]
		public string slotName;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x28")]
		public bool isTrigger;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x29")]
		public bool clearStateOnDisable;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x30")]
		private Slot slot;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x38")]
		private BoundingBoxAttachment currentAttachment;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x40")]
		private string currentAttachmentName;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x48")]
		private PolygonCollider2D currentCollider;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x50")]
		public readonly Dictionary<BoundingBoxAttachment, PolygonCollider2D> colliderTable;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x58")]
		public readonly Dictionary<BoundingBoxAttachment, string> nameTable;
	}
}
