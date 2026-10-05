using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200329F RID: 12959
	[Token(Token = "0x200329F")]
	public class UIAutoChessDragEquipPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601496B RID: 84331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601496B")]
		[Address(RVA = "0xCD82C0", Offset = "0xCD6EC0", VA = "0x180CD82C0")]
		public void Render(UIAutoChessDragEquipPanel.Param param)
		{
		}

		// Token: 0x0601496C RID: 84332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601496C")]
		[Address(RVA = "0xCD8700", Offset = "0xCD7300", VA = "0x180CD8700")]
		private Sprite _GetEquipIconSprite(int index)
		{
			return null;
		}

		// Token: 0x0601496D RID: 84333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601496D")]
		[Address(RVA = "0xCD80E0", Offset = "0xCD6CE0", VA = "0x180CD80E0")]
		public void Hide()
		{
		}

		// Token: 0x0601496E RID: 84334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601496E")]
		[Address(RVA = "0xCD8840", Offset = "0xCD7440", VA = "0x180CD8840")]
		private void _PlayAnimLocationIfNotActive(UIAnimationLocation location, [Optional] TweenCallback callback)
		{
		}

		// Token: 0x0601496F RID: 84335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601496F")]
		[Address(RVA = "0xCD8020", Offset = "0xCD6C20", VA = "0x180CD8020")]
		public void EquipCharacter(int equipCnt, TweenCallback callback)
		{
		}

		// Token: 0x06014970 RID: 84336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014970")]
		[Address(RVA = "0xCD8260", Offset = "0xCD6E60", VA = "0x180CD8260")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014971 RID: 84337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014971")]
		[Address(RVA = "0xCD8630", Offset = "0xCD7230", VA = "0x180CD8630")]
		private void _FinishTweenIfNot(bool completeTween)
		{
		}

		// Token: 0x06014972 RID: 84338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014972")]
		[Address(RVA = "0xCD8950", Offset = "0xCD7550", VA = "0x180CD8950")]
		public UIAutoChessDragEquipPanel()
		{
		}

		// Token: 0x040185BC RID: 99772
		[Token(Token = "0x40185BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFollower _follower;

		// Token: 0x040185BD RID: 99773
		[Token(Token = "0x40185BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _beginAnim;

		// Token: 0x040185BE RID: 99774
		[Token(Token = "0x40185BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _endAnim;

		// Token: 0x040185BF RID: 99775
		[Token(Token = "0x40185BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _leftAnim;

		// Token: 0x040185C0 RID: 99776
		[Token(Token = "0x40185C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _rightAnim;

		// Token: 0x040185C1 RID: 99777
		[Token(Token = "0x40185C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _normalFrame;

		// Token: 0x040185C2 RID: 99778
		[Token(Token = "0x40185C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _fullFrame;

		// Token: 0x040185C3 RID: 99779
		[Token(Token = "0x40185C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _fullMatte;

		// Token: 0x040185C4 RID: 99780
		[Token(Token = "0x40185C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _leftNormalGroup;

		// Token: 0x040185C5 RID: 99781
		[Token(Token = "0x40185C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _leftEmptyGroup;

		// Token: 0x040185C6 RID: 99782
		[Token(Token = "0x40185C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _rightNormalGroup;

		// Token: 0x040185C7 RID: 99783
		[Token(Token = "0x40185C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform _rightEmptyGroup;

		// Token: 0x040185C8 RID: 99784
		[Token(Token = "0x40185C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool m_isHide;

		// Token: 0x040185C9 RID: 99785
		[Token(Token = "0x40185C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<int> m_equipInstIds;

		// Token: 0x040185CA RID: 99786
		[Token(Token = "0x40185CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Tween m_tween;

		// Token: 0x040185CB RID: 99787
		[Token(Token = "0x40185CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040185CC RID: 99788
		[Token(Token = "0x40185CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetEquipIconSprite;

		// Token: 0x040185CD RID: 99789
		[Token(Token = "0x40185CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040185CE RID: 99790
		[Token(Token = "0x40185CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayAnimLocationIfNotActive;

		// Token: 0x040185CF RID: 99791
		[Token(Token = "0x40185CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EquipCharacter;

		// Token: 0x040185D0 RID: 99792
		[Token(Token = "0x40185D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040185D1 RID: 99793
		[Token(Token = "0x40185D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FinishTweenIfNot;

		// Token: 0x040185D2 RID: 99794
		[Token(Token = "0x40185D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032A0 RID: 12960
		[Token(Token = "0x20032A0")]
		public struct Param
		{
			// Token: 0x040185D3 RID: 99795
			[Token(Token = "0x40185D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<int> equipInstIds;

			// Token: 0x040185D4 RID: 99796
			[Token(Token = "0x40185D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Tile followTile;
		}
	}
}
