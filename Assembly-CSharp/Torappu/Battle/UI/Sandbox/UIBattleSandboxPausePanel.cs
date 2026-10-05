using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Sandbox;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033B2 RID: 13234
	[Token(Token = "0x20033B2")]
	public class UIBattleSandboxPausePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x060151EA RID: 86506 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060151EB RID: 86507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700321F")]
		private SandboxCameraPlugin cameraPlugin
		{
			[Token(Token = "0x60151EA")]
			[Address(RVA = "0xD94560", Offset = "0xD93160", VA = "0x180D94560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60151EB")]
			[Address(RVA = "0xD945C0", Offset = "0xD931C0", VA = "0x180D945C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060151EC RID: 86508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151EC")]
		[Address(RVA = "0xD94220", Offset = "0xD92E20", VA = "0x180D94220")]
		public void ProcessLevelData(LevelData data)
		{
		}

		// Token: 0x060151ED RID: 86509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151ED")]
		[Address(RVA = "0xD93EF0", Offset = "0xD92AF0", VA = "0x180D93EF0")]
		public void OnUpdate()
		{
		}

		// Token: 0x060151EE RID: 86510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151EE")]
		[Address(RVA = "0xD94500", Offset = "0xD93100", VA = "0x180D94500")]
		public UIBattleSandboxPausePanel()
		{
		}

		// Token: 0x040192AD RID: 103085
		[Token(Token = "0x40192AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("GameObject refs")]
		private RectTransform _camView;

		// Token: 0x040192AE RID: 103086
		[Token(Token = "0x40192AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Colors")]
		private Color _tileLowLandColor;

		// Token: 0x040192AF RID: 103087
		[Token(Token = "0x40192AF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Colors")]
		private Color _tileHighlandColor;

		// Token: 0x040192B0 RID: 103088
		[Token(Token = "0x40192B0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public UIBattleSandboxMapView _mapView;

		// Token: 0x040192B1 RID: 103089
		[Token(Token = "0x40192B1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("GameObject refs")]
		private RectTransform _camViewOffset;

		// Token: 0x040192B2 RID: 103090
		[Token(Token = "0x40192B2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _mapViewRoot;

		// Token: 0x040192B4 RID: 103092
		[Token(Token = "0x40192B4")]
		[FieldOffset(Offset = "0x60")]
		private UIBattleSandboxMapView m_mapView;

		// Token: 0x040192B5 RID: 103093
		[Token(Token = "0x40192B5")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 m_constOffset;

		// Token: 0x040192B6 RID: 103094
		[Token(Token = "0x40192B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cameraPlugin;

		// Token: 0x040192B7 RID: 103095
		[Token(Token = "0x40192B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_cameraPlugin;

		// Token: 0x040192B8 RID: 103096
		[Token(Token = "0x40192B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ProcessLevelData;

		// Token: 0x040192B9 RID: 103097
		[Token(Token = "0x40192B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x040192BA RID: 103098
		[Token(Token = "0x40192BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
