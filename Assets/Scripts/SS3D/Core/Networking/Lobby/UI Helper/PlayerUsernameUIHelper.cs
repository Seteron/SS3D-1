using TMPro;
using UnityEngine;

namespace SS3D.Core.Lobby.UI
{
    /// <summary>
    /// Simple Username ui element controller
    /// </summary>
    public sealed class PlayerUsernameUIHelper : MonoBehaviour
    {
        [SerializeField] private TMP_Text _nameLabel;

        public string Name => _nameLabel.text;
    
        public void UpdateNameText(string newName)
        {
            _nameLabel.text = newName;
        }
    }
}
