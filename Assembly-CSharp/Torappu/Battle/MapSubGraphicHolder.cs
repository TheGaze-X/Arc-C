using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002365 RID: 9061
	[Token(Token = "0x2002365")]
	public class MapSubGraphicHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x0600E5A3 RID: 58787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CCB")]
		public MapSubGraphicHolder.SubGraphicSetting[] settings
		{
			[Token(Token = "0x600E5A3")]
			[Address(RVA = "0x5C3450", Offset = "0x5C2050", VA = "0x1805C3450")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E5A4 RID: 58788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5A4")]
		[Address(RVA = "0x5C2E80", Offset = "0x5C1A80", VA = "0x1805C2E80")]
		public void EnableSubGraphic(string subGraphicKey)
		{
		}

		// Token: 0x0600E5A5 RID: 58789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5A5")]
		[Address(RVA = "0x5C2B90", Offset = "0x5C1790", VA = "0x1805C2B90")]
		public void DisableSubGraphic(string subGraphicKey)
		{
		}

		// Token: 0x0600E5A6 RID: 58790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5A6")]
		[Address(RVA = "0x5C27C0", Offset = "0x5C13C0", VA = "0x1805C27C0")]
		public void CollectSubGraphicRenders(string key, ref List<MeshRenderer> items)
		{
		}

		// Token: 0x0600E5A7 RID: 58791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5A7")]
		[Address(RVA = "0x5C33F0", Offset = "0x5C1FF0", VA = "0x1805C33F0")]
		public MapSubGraphicHolder()
		{
		}

		// Token: 0x0400FD6E RID: 64878
		[Token(Token = "0x400FD6E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MapSubGraphicHolder.SubGraphicSetting[] _settings;

		// Token: 0x0400FD6F RID: 64879
		[Token(Token = "0x400FD6F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _hideBakeOffset;

		// Token: 0x0400FD70 RID: 64880
		[Token(Token = "0x400FD70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_settings;

		// Token: 0x0400FD71 RID: 64881
		[Token(Token = "0x400FD71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EnableSubGraphic;

		// Token: 0x0400FD72 RID: 64882
		[Token(Token = "0x400FD72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DisableSubGraphic;

		// Token: 0x0400FD73 RID: 64883
		[Token(Token = "0x400FD73")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CollectSubGraphicRenders;

		// Token: 0x0400FD74 RID: 64884
		[Token(Token = "0x400FD74")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002366 RID: 9062
		[Token(Token = "0x2002366")]
		[Serializable]
		public struct SubGraphicSetting
		{
			// Token: 0x0600E5A8 RID: 58792 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600E5A8")]
			[Address(RVA = "0x5CB160", Offset = "0x5C9D60", VA = "0x1805CB160", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0600E5A9 RID: 58793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5A9")]
			[Address(RVA = "0x5CAE50", Offset = "0x5C9A50", VA = "0x1805CAE50")]
			[Inspect]
			public void CloseObjects()
			{
			}

			// Token: 0x0600E5AA RID: 58794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5AA")]
			[Address(RVA = "0x5CAE60", Offset = "0x5C9A60", VA = "0x1805CAE60")]
			[Inspect]
			public void OpenObjects()
			{
			}

			// Token: 0x0600E5AB RID: 58795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5AB")]
			[Address(RVA = "0x5CAE70", Offset = "0x5C9A70", VA = "0x1805CAE70")]
			private void SetObjectsActive(bool active)
			{
			}

			// Token: 0x0400FD75 RID: 64885
			[Token(Token = "0x400FD75")]
			[FieldOffset(Offset = "0x0")]
			public string key;

			// Token: 0x0400FD76 RID: 64886
			[Token(Token = "0x400FD76")]
			[FieldOffset(Offset = "0x8")]
			public bool hide;

			// Token: 0x0400FD77 RID: 64887
			[Token(Token = "0x400FD77")]
			[FieldOffset(Offset = "0x10")]
			public List<GameObject> items;

			// Token: 0x0400FD78 RID: 64888
			[Token(Token = "0x400FD78")]
			[FieldOffset(Offset = "0x18")]
			public List<GameObject> playgroundItems;

			// Token: 0x0400FD79 RID: 64889
			[Token(Token = "0x400FD79")]
			[FieldOffset(Offset = "0x20")]
			public List<string> effects;
		}
	}
}
