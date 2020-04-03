﻿namespace SnaffCore.Config
{
    public partial class Options
    {
        public string[] FileNamesToKeep { get; set; } =
        {
            // these are file names that we always want to keep if it's an exact match.
            "id_rsa",
            "id_dsa",
            "NTDS.DIT",
            "shadow",
            "pwd.db",
            "unattend.xml",
            ".netrc",
            "_netrc",
            ".htaccess",
            "otr.private_key",
            ".secret_token.rb",
            "carrierwave.rb",
            "database.yml",
            "omniauth.rb",
            "settings.py",
            ".agilekeychain",
            ".keychain",
            "jenkins.plugins.publish_over_ssh.BapSshPublisherPlugin.xml",
            "credentials.xml",
            "LocalSettings.php",
            "Favorites.plist",
            "knife.rb",
            "proxy.config",
            "proftpdpasswd",
            "robomongo.json",
            "filezilla.xml",
            "recentservers.xml",
            "terraform.tfvars",
            ".exports",
            ".functions",
            ".extra",
            "bash_history",
            "zsh_history",
            "sh_history",
            "zhistory",
            "mysql_history",
            "psql_history",
            ".pgpass",
            ".irb_history",
            ".dbeaver-data-sources.xml",
            ".s3vfg",
            "sftp-config.json",
            "config.inc",
            "config.php",
            "keystore",
            "keyring",
            ".tugboat",
            ".git-credentials",
            ".gitconfig",
            "passwd",
            "shadow",
            ".dockercfg",
            ".npmrc",
            ".env"
        };
    }
}