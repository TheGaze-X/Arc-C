using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	[ExecuteAlways]
	[HelpURL("http://esotericsoftware.com/spine-unity#BoundingBoxFollower")]
	public class BoundingBoxFollower : MonoBehaviour
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000183")]
		public Slot Slot
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000184")]
		public BoundingBoxAttachment CurrentAttachment
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000185")]
		public string CurrentAttachmentName
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000186")]
		public PolygonCollider2D CurrentCollider
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x000040DC File Offset: 0x000022DC
		[Token(Token = "0x17000187")]
		public bool IsTrigger
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x4E790B0", Offset = "0x4E77CB0", VA = "0x184E790B0")]
		private void Start()
		{
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x4E79B60", Offset = "0x4E78760", VA = "0x184E79B60")]
		private void OnEnable()
		{
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x4E790B0", Offset = "0x4E77CB0", VA = "0x184E790B0")]
		private void HandleRebuild(SkeletonRenderer sr)
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x4E790C0", Offset = "0x4E77CC0", VA = "0x184E790C0")]
		public void Initialize(bool overwrite = false)
		{
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x4E78A20", Offset = "0x4E77620", VA = "0x184E78A20")]
		private void AddCollidersForSkin(Skin skin, int slotIndex, PolygonCollider2D[] previousColliders, ref int collidersCount)
		{
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x4E79A80", Offset = "0x4E78680", VA = "0x184E79A80")]
		private void OnDisable()
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x4E78E40", Offset = "0x4E77A40", VA = "0x184E78E40")]
		public void ClearState()
		{
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x4E78FD0", Offset = "0x4E77BD0", VA = "0x184E78FD0")]
		private void DisposeExcessCollidersAfter(int requiredCount)
		{
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x4E796E0", Offset = "0x4E782E0", VA = "0x184E796E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x4E79700", Offset = "0x4E78300", VA = "0x184E79700")]
		private void MatchAttachment(Attachment attachment)
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x4E79CC0", Offset = "0x4E788C0", VA = "0x184E79CC0")]
		public BoundingBoxFollower()
		{
		}

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x0")]
		internal static bool DebugMessages;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x18")]
		public SkeletonRenderer skeletonRenderer;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x20")]
		[SpineSlot("", "skeletonRenderer", true, true, false)]
		public string slotName;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x28")]
		public bool isTrigger;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x29")]
		public bool clearStateOnDisable;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x30")]
		private Slot slot;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x38")]
		private BoundingBoxAttachment currentAttachment;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x40")]
		private string currentAttachmentName;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x48")]
		private PolygonCollider2D currentCollider;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x50")]
		public readonly Dictionary<BoundingBoxAttachment, PolygonCollider2D> colliderTable;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x58")]
		public readonly Dictionary<BoundingBoxAttachment, string> nameTable;
	}
}
