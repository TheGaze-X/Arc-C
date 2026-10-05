using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A7E RID: 6782
	[Token(Token = "0x2001A7E")]
	[RequireComponent(typeof(RectTransform))]
	public abstract class VOUIPanel : MonoBehaviour
	{
		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x0600AAE4 RID: 43748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700142B")]
		[Inspect(Level = 2)]
		protected VRoom.Object bindedObject
		{
			[Token(Token = "0x600AAE4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x0600AAE5 RID: 43749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700142C")]
		protected VRoom.Object roomObject
		{
			[Token(Token = "0x600AAE5")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AAE6 RID: 43750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAE6")]
		[Address(RVA = "0x3264CB0", Offset = "0x32638B0", VA = "0x183264CB0")]
		protected void DismissSelf()
		{
		}

		// Token: 0x0600AAE7 RID: 43751
		[Token(Token = "0x600AAE7")]
		public abstract bool MatchObject(BuildingEvent evt, VRoom.Object roomObject);

		// Token: 0x0600AAE8 RID: 43752 RVA: 0x00042210 File Offset: 0x00040410
		[Token(Token = "0x600AAE8")]
		[Address(RVA = "0x3264CC0", Offset = "0x32638C0", VA = "0x183264CC0", Slot = "5")]
		protected virtual Vector3 PanelWorldCenter()
		{
			return default(Vector3);
		}

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAE9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		protected virtual void OnRoomObjectBinded(VRoom.Object roomObj)
		{
		}

		// Token: 0x0600AAEA RID: 43754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAEA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected virtual void OnRoomObjectStatusChanged()
		{
		}

		// Token: 0x0600AAEB RID: 43755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAEB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		protected virtual void OnRoomObjectUnbinded(VRoom.Object oldRoomObj)
		{
		}

		// Token: 0x0600AAEC RID: 43756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAEC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		protected virtual void UpdateRender()
		{
		}

		// Token: 0x0600AAED RID: 43757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAED")]
		[Address(RVA = "0x3264DC0", Offset = "0x32639C0", VA = "0x183264DC0")]
		public void UpdateUI(VRoom.Object roomObject)
		{
		}

		// Token: 0x0600AAEE RID: 43758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAEE")]
		[Address(RVA = "0x3264D80", Offset = "0x3263980", VA = "0x183264D80")]
		public void TriggerRoomObjectStatusChanged()
		{
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x0600AAEF RID: 43759 RVA: 0x00042228 File Offset: 0x00040428
		[Token(Token = "0x1700142D")]
		public bool isShow
		{
			[Token(Token = "0x600AAEF")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600AAF0 RID: 43760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF0")]
		[Address(RVA = "0x3264C00", Offset = "0x3263800", VA = "0x183264C00")]
		public void Clear()
		{
		}

		// Token: 0x0600AAF1 RID: 43761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF1")]
		[Address(RVA = "0x3265090", Offset = "0x3263C90", VA = "0x183265090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600AAF2 RID: 43762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF2")]
		[Address(RVA = "0x3264F80", Offset = "0x3263B80", VA = "0x183264F80")]
		private void _BindObjectIfNeeded(VRoom.Object obj)
		{
		}

		// Token: 0x0600AAF3 RID: 43763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF3")]
		[Address(RVA = "0x3265130", Offset = "0x3263D30", VA = "0x183265130")]
		private void _UpdatePosition()
		{
		}

		// Token: 0x0600AAF4 RID: 43764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF4")]
		[Address(RVA = "0x3253DC0", Offset = "0x32529C0", VA = "0x183253DC0")]
		protected VOUIPanel()
		{
		}

		// Token: 0x0400A347 RID: 41799
		[Token(Token = "0x400A347")]
		private const float SCALE_MULTI = 3f;

		// Token: 0x0400A348 RID: 41800
		[Token(Token = "0x400A348")]
		private const float SCALE_BIAS = 0f;

		// Token: 0x0400A349 RID: 41801
		[Token(Token = "0x400A349")]
		private const float CHANGE_THRESHOLD = 0.1f;

		// Token: 0x0400A34A RID: 41802
		[Token(Token = "0x400A34A")]
		[FieldOffset(Offset = "0x18")]
		private VRoom.Object m_cacheObject;

		// Token: 0x0400A34B RID: 41803
		[Token(Token = "0x400A34B")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x0400A34C RID: 41804
		[Token(Token = "0x400A34C")]
		[FieldOffset(Offset = "0x21")]
		private bool m_isShow;
	}
}
