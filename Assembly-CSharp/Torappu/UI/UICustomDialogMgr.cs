using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A90 RID: 14992
	[Token(Token = "0x2003A90")]
	public class UICustomDialogMgr : SingletonMonoBehaviour<UICustomDialogMgr>, IHotfixable
	{
		// Token: 0x06017B29 RID: 97065 RVA: 0x00097BA8 File Offset: 0x00095DA8
		[Token(Token = "0x6017B29")]
		public bool Show<DialogType, OptionType>(UICustomDialogMgr.DynDialogParam dialogParam, OptionType options) where DialogType : UICustomDialog<OptionType>
		{
			return default(bool);
		}

		// Token: 0x06017B2A RID: 97066 RVA: 0x00097BC0 File Offset: 0x00095DC0
		[Token(Token = "0x6017B2A")]
		public bool Show<DialogType, OptionType>(UICustomDialogMgr.StaticDialogParam dialogParam, OptionType options) where DialogType : UICustomDialog<OptionType>
		{
			return default(bool);
		}

		// Token: 0x06017B2B RID: 97067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B2B")]
		public void DialogMessage<DialogType>(int msg, ValueBundle param) where DialogType : MonoBehaviour, IValueMsgReceiver
		{
		}

		// Token: 0x06017B2C RID: 97068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B2C")]
		public void DialogMessage<DialogType>(int msg) where DialogType : MonoBehaviour, IValueMsgReceiver
		{
		}

		// Token: 0x06017B2D RID: 97069 RVA: 0x00097BD8 File Offset: 0x00095DD8
		[Token(Token = "0x6017B2D")]
		private bool _ShowDialogImpl<DialogType, OptionType>(DialogType dialog, OptionType options) where DialogType : UICustomDialog<OptionType>
		{
			return default(bool);
		}

		// Token: 0x06017B2E RID: 97070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B2E")]
		[Address(RVA = "0xFF5390", Offset = "0xFF3F90", VA = "0x180FF5390")]
		public void DialogCore_DestroyDialog(int instCode)
		{
		}

		// Token: 0x06017B2F RID: 97071 RVA: 0x00097BF0 File Offset: 0x00095DF0
		[Token(Token = "0x6017B2F")]
		[Address(RVA = "0xFF54A0", Offset = "0xFF40A0", VA = "0x180FF54A0")]
		public UICustomDialogMgr.CameraWrapper DialogCore_GetCameraWrapper()
		{
			return default(UICustomDialogMgr.CameraWrapper);
		}

		// Token: 0x06017B30 RID: 97072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B30")]
		[Address(RVA = "0xFF5520", Offset = "0xFF4120", VA = "0x180FF5520")]
		public void DialogCore_HookFindViewableCameras(IList<Camera> cameraList)
		{
		}

		// Token: 0x06017B31 RID: 97073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B31")]
		[Address(RVA = "0xFF5A00", Offset = "0xFF4600", VA = "0x180FF5A00")]
		private void _LoadUiCameraIfNecessary()
		{
		}

		// Token: 0x06017B32 RID: 97074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B32")]
		[Address(RVA = "0xFF5C30", Offset = "0xFF4830", VA = "0x180FF5C30")]
		private void _UnloadUnusedPrefabs()
		{
		}

		// Token: 0x06017B33 RID: 97075 RVA: 0x00097C08 File Offset: 0x00095E08
		[Token(Token = "0x6017B33")]
		[Address(RVA = "0xFF58A0", Offset = "0xFF44A0", VA = "0x180FF58A0")]
		private int _GetAssetGroup()
		{
			return 0;
		}

		// Token: 0x06017B34 RID: 97076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B34")]
		[Address(RVA = "0xFF5B20", Offset = "0xFF4720", VA = "0x180FF5B20")]
		private static void _UnloadDialog(GameObject prefab, int assetGroup)
		{
		}

		// Token: 0x06017B35 RID: 97077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017B35")]
		private DialogType _CreateDialogInst<DialogType>(UICustomDialogMgr.DynDialogParam dialogParam) where DialogType : MonoBehaviour
		{
			return null;
		}

		// Token: 0x06017B36 RID: 97078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017B36")]
		private DialogType _CreateDialogInst<DialogType>(UICustomDialogMgr.StaticDialogParam dialogParam) where DialogType : MonoBehaviour
		{
			return null;
		}

		// Token: 0x06017B37 RID: 97079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017B37")]
		[Address(RVA = "0xFF5900", Offset = "0xFF4500", VA = "0x180FF5900")]
		private static GameObject _LoadDialog(string resPath, int assetGroup)
		{
			return null;
		}

		// Token: 0x06017B38 RID: 97080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B38")]
		[Address(RVA = "0xFF5600", Offset = "0xFF4200", VA = "0x180FF5600")]
		private void OnDisable()
		{
		}

		// Token: 0x06017B39 RID: 97081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B39")]
		[Address(RVA = "0xFF5660", Offset = "0xFF4260", VA = "0x180FF5660")]
		private void _DisposeSelf()
		{
		}

		// Token: 0x06017B3A RID: 97082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B3A")]
		[Address(RVA = "0xFF5E20", Offset = "0xFF4A20", VA = "0x180FF5E20")]
		public UICustomDialogMgr()
		{
		}

		// Token: 0x0401C97A RID: 117114
		[Token(Token = "0x401C97A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0401C97B RID: 117115
		[Token(Token = "0x401C97B")]
		[FieldOffset(Offset = "0x20")]
		private List<UICustomDialogMgr.DialogWrapper> m_dialogInsts;

		// Token: 0x0401C97C RID: 117116
		[Token(Token = "0x401C97C")]
		[FieldOffset(Offset = "0x28")]
		private List<UICustomDialogMgr.PrefabWrapper> m_loadedPrefabs;

		// Token: 0x0401C97D RID: 117117
		[Token(Token = "0x401C97D")]
		[FieldOffset(Offset = "0x30")]
		private Camera m_uiCamera;

		// Token: 0x0401C97E RID: 117118
		[Token(Token = "0x401C97E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0401C97F RID: 117119
		[Token(Token = "0x401C97F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Show;

		// Token: 0x0401C980 RID: 117120
		[Token(Token = "0x401C980")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DialogMessage;

		// Token: 0x0401C981 RID: 117121
		[Token(Token = "0x401C981")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_DialogMessage;

		// Token: 0x0401C982 RID: 117122
		[Token(Token = "0x401C982")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowDialogImpl;

		// Token: 0x0401C983 RID: 117123
		[Token(Token = "0x401C983")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DialogCore_DestroyDialog;

		// Token: 0x0401C984 RID: 117124
		[Token(Token = "0x401C984")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DialogCore_GetCameraWrapper;

		// Token: 0x0401C985 RID: 117125
		[Token(Token = "0x401C985")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DialogCore_HookFindViewableCameras;

		// Token: 0x0401C986 RID: 117126
		[Token(Token = "0x401C986")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadUiCameraIfNecessary;

		// Token: 0x0401C987 RID: 117127
		[Token(Token = "0x401C987")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UnloadUnusedPrefabs;

		// Token: 0x0401C988 RID: 117128
		[Token(Token = "0x401C988")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetAssetGroup;

		// Token: 0x0401C989 RID: 117129
		[Token(Token = "0x401C989")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UnloadDialog;

		// Token: 0x0401C98A RID: 117130
		[Token(Token = "0x401C98A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CreateDialogInst;

		// Token: 0x0401C98B RID: 117131
		[Token(Token = "0x401C98B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix1__CreateDialogInst;

		// Token: 0x0401C98C RID: 117132
		[Token(Token = "0x401C98C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LoadDialog;

		// Token: 0x0401C98D RID: 117133
		[Token(Token = "0x401C98D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401C98E RID: 117134
		[Token(Token = "0x401C98E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DisposeSelf;

		// Token: 0x0401C98F RID: 117135
		[Token(Token = "0x401C98F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003A91 RID: 14993
		[Token(Token = "0x2003A91")]
		private struct DialogWrapper
		{
			// Token: 0x170038DD RID: 14557
			// (get) Token: 0x06017B3B RID: 97083 RVA: 0x00097C20 File Offset: 0x00095E20
			// (set) Token: 0x06017B3C RID: 97084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038DD")]
			public int instCode
			{
				[Token(Token = "0x6017B3B")]
				[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x6017B3C")]
				[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170038DE RID: 14558
			// (get) Token: 0x06017B3D RID: 97085 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06017B3E RID: 97086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038DE")]
			public GameObject inst
			{
				[Token(Token = "0x6017B3D")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6017B3E")]
				[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170038DF RID: 14559
			// (get) Token: 0x06017B3F RID: 97087 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06017B40 RID: 97088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038DF")]
			public MonoBehaviour component
			{
				[Token(Token = "0x6017B3F")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6017B40")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170038E0 RID: 14560
			// (get) Token: 0x06017B41 RID: 97089 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06017B42 RID: 97090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038E0")]
			public GameObject prefab
			{
				[Token(Token = "0x6017B41")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6017B42")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06017B43 RID: 97091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B43")]
			[Address(RVA = "0xFE9220", Offset = "0xFE7E20", VA = "0x180FE9220")]
			public DialogWrapper(MonoBehaviour dialogInst, GameObject prefab)
			{
			}
		}

		// Token: 0x02003A92 RID: 14994
		[Token(Token = "0x2003A92")]
		private struct PrefabWrapper
		{
			// Token: 0x0401C994 RID: 117140
			[Token(Token = "0x401C994")]
			[FieldOffset(Offset = "0x0")]
			public GameObject prefab;

			// Token: 0x0401C995 RID: 117141
			[Token(Token = "0x401C995")]
			[FieldOffset(Offset = "0x8")]
			public string resPath;
		}

		// Token: 0x02003A93 RID: 14995
		[Token(Token = "0x2003A93")]
		public struct DynDialogParam
		{
			// Token: 0x0401C996 RID: 117142
			[Token(Token = "0x401C996")]
			[FieldOffset(Offset = "0x0")]
			public string resPath;

			// Token: 0x0401C997 RID: 117143
			[Token(Token = "0x401C997")]
			[FieldOffset(Offset = "0x8")]
			public bool forceSingleInst;
		}

		// Token: 0x02003A94 RID: 14996
		[Token(Token = "0x2003A94")]
		public struct StaticDialogParam
		{
			// Token: 0x0401C998 RID: 117144
			[Token(Token = "0x401C998")]
			[FieldOffset(Offset = "0x0")]
			public GameObject prefab;
		}

		// Token: 0x02003A95 RID: 14997
		[Token(Token = "0x2003A95")]
		public struct CameraWrapper
		{
			// Token: 0x170038E1 RID: 14561
			// (get) Token: 0x06017B44 RID: 97092 RVA: 0x00097C38 File Offset: 0x00095E38
			[Token(Token = "0x170038E1")]
			public bool isEmpty
			{
				[Token(Token = "0x6017B44")]
				[Address(RVA = "0xFE1590", Offset = "0xFE0190", VA = "0x180FE1590")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06017B45 RID: 97093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B45")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public CameraWrapper(Camera camera)
			{
			}

			// Token: 0x06017B46 RID: 97094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B46")]
			[Address(RVA = "0xFE1150", Offset = "0xFDFD50", VA = "0x180FE1150")]
			public void BindWebView(UIUniWebView webview)
			{
			}

			// Token: 0x06017B47 RID: 97095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B47")]
			[Address(RVA = "0xFE10A0", Offset = "0xFDFCA0", VA = "0x180FE10A0")]
			public void BindCanvas(Canvas canvas)
			{
			}

			// Token: 0x06017B48 RID: 97096 RVA: 0x00097C50 File Offset: 0x00095E50
			[Token(Token = "0x6017B48")]
			[Address(RVA = "0xFE1200", Offset = "0xFDFE00", VA = "0x180FE1200")]
			public Bounds GetTargetWithDiffCamera(RectTransform target, Camera targetCamera, RectTransform local)
			{
				return default(Bounds);
			}

			// Token: 0x06017B49 RID: 97097 RVA: 0x00097C68 File Offset: 0x00095E68
			[Token(Token = "0x6017B49")]
			[Address(RVA = "0xFE1470", Offset = "0xFE0070", VA = "0x180FE1470")]
			public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint)
			{
				return default(bool);
			}

			// Token: 0x0401C999 RID: 117145
			[Token(Token = "0x401C999")]
			[FieldOffset(Offset = "0x0")]
			private Camera m_inst;
		}
	}
}
